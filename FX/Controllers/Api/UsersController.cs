using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FX.Models;

namespace FX.Controllers.Api
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        
        [HttpGet]
        public IEnumerable<ApplicationUser> applicationUsers()
        {

            return _context.Users.ToList();
            
        }
    }
}
