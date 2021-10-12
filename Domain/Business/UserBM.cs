using Infrastructure.Entities;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Infrastructure.DTO;

namespace Domain.Business
{

    public interface IUserBM
    {
        List<UsersModel> GetAll();
        UsersModel Create(UsersModel user);
        UsersModel AuthenticateUser(Login login);
        UsersModel Update(UsersModel user);
        UsersModel Delete(UsersModel user);

    }


   public class UserBM: IUserBM
    {
        public IUserRepository _userRepository;

        public UserBM(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<UsersModel> GetAll() {
           return _userRepository.GetAll().ToList();
        }

        public UsersModel Create(UsersModel user) 
        
        {
            return _userRepository.Create(user);

        }

        public UsersModel Update(UsersModel user)

        {
            return _userRepository.Update(user);

        }

        public UsersModel Delete(UsersModel user)
        {
            return _userRepository.Delete(user);
        }

        public UsersModel AuthenticateUser(Login login)
        {
            return _userRepository.Login(login);
            
        }

    }
}
