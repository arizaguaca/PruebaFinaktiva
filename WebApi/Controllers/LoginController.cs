using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Business;
using Infrastructure.DTO;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        public ILoginBM _Login;


        public LoginController(ILoginBM login)
        {

            _Login = login;
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public Response Login([FromBody] Login login)
        {
                return _Login.Login(login);
        }

    }
}