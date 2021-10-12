using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Business;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserBM _user;
   
        public UserController(IUserBM user ) {

            _user = user;
        }

        [HttpGet]
        [Authorize(Policy = Policies.User)]
        [Route("GetAll")]
        public List<UsersModel> GetAll()
        {
            return  _user.GetAll();

        }


        [HttpPost]
        [Authorize(Policy = Policies.Admin)]
        [Route("Create")]
        public UsersModel Create([FromBody] UsersModel user)
        {
            return _user.Create(user);
        }


        [HttpPost]
        [Authorize(Policy = Policies.Admin)]
        [Route("Update")]
        public UsersModel Update([FromBody] UsersModel user)
        {
            return _user.Update(user);
        }


        [HttpPost]
        [Authorize(Policy = Policies.Admin)]
        [Route("Delete")]
        public UsersModel Delete([FromBody] UsersModel user)
        {
            return _user.Delete(user);
        }

    }
}