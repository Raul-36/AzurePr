using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzurePr.Models;
using AzurePr.Rep;
using Microsoft.AspNetCore.Mvc;

namespace AzurePr.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserRep rep = new UserRep();
        
        public async Task<ActionResult<IEnumerable<User>>>  GetUsers(){
             return Ok(await rep.GetAll());
        }
    }
}