
using Persistence.Database.Context;
using Infrastructure.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Infrastructure.DTO;
using System;

namespace Persistence.Repositories
{
    public interface IUserRepository
    {
        IQueryable<UsersModel> GetAll();

        UsersModel Login(Login login);

        UsersModel Create(UsersModel user, bool autoSave = true);
        UsersModel Update(UsersModel user);

        UsersModel Delete(UsersModel user);

    }
        public class UserRepository : IUserRepository
        {

            protected DbContext _dbcontext;

            protected DbSet<UsersModel> _DbSetUser;



            public UserRepository(DbContext database)
            {

                _dbcontext = database;
                _DbSetUser = _dbcontext.Set<UsersModel>();


            }


            public IQueryable<UsersModel> GetAll()
            {
                return _DbSetUser;

            }


            public UsersModel Create(UsersModel user, bool autoSave = true)
            {

                _DbSetUser.Add(user);
                _dbcontext.SaveChanges();
                return user;
            }

            public UsersModel Update(UsersModel user)
            {

                UsersModel val = _DbSetUser.Find(GetValuePrimaryKey(user));

                if (val != null)
                {

                _dbcontext.Entry(val).CurrentValues.SetValues(user);
                _dbcontext.SaveChanges();
               
                }
            return user;

            }


            public UsersModel Delete(UsersModel user)
            {

            UsersModel val = _DbSetUser.Find(GetValuePrimaryKey(user));

                if (val != null)
                {
                    _DbSetUser.Remove(val);
                    _dbcontext.SaveChanges();

            }
            else
            {
                throw new ApplicationException("El IdUser no existe");
            }
            return user;
        }

            public UsersModel Login(Login login)
            {

                var data = GetAll().Where(x => x.Password == login.Pass && x.Name == login.User).FirstOrDefault();
                return data;

            }


            protected object GetValuePrimaryKey(UsersModel user)
            {
                string keyName = GetPrimaryKeyName();
                object value = typeof(UsersModel).GetProperty(keyName).GetValue(user);
                return value;
            }



        protected string GetPrimaryKeyName()
        {
            var keyNames = _dbcontext.Model.FindEntityType(typeof(UsersModel)).FindPrimaryKey().Properties.Select(x => x.Name);
            string keyName = keyNames.FirstOrDefault();

            if (keyNames.Count() > 1)
            {
                throw new ApplicationException("Error");
            }

            if (keyName == null)
            {
                throw new ApplicationException("Error");
            }

            return keyName;
        }

        protected object CastPrimaryKey(object id)
        {
            string keyName = GetPrimaryKeyName();
            Type keyType = typeof(UsersModel).GetProperty(keyName).PropertyType;
            return Convert.ChangeType(id, keyType);
        }

    }

}
