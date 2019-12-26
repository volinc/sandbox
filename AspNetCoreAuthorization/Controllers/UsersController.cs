namespace AspNetCoreAuthorization.Controllers
{
    using AspNetCoreAuthorization.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        public IEnumerable<User> ReadAll()
        {
            return new User[0];
        }
    }
}
