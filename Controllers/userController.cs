using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using blogApi.repositories.user;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace blogApi.Controllers
{
   
    [Route("api/users/")]
    [ApiController]
    public class UserController: ControllerBase{
        private  IUserRepository _repo;
        public UserController(IUserRepository repo){
            _repo = repo;
        }

        [HttpGet]
        [Authorize]
        [Route("get")]
        public ActionResult<IEnumerable<User>> Get(){
            var allusers = _repo.Get();
            return allusers;
        }

      
        
    }
}