using Domain.Business;
using Infrastructure.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
   public class TestLogin
    {
        public ILoginBM _Login;
        [TestMethod]
        public void loginTrue()
        {
            Login user = new Login();

            user.User = "Victor";
            user.Pass = "123";

           var result= _Login.Login(user);

            Assert.AreEqual(user,result);
        }
    }
}
