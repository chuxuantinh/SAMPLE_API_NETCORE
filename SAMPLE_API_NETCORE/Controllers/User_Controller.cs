using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAMPLE_API_NETCORE.Entities;
using SAMPLE_API_NETCORE.Models;
using System.Net;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SAMPLE_API_NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {

        private readonly LABHUB2022Context LABHUB2022Context;

        public User_Controller(LABHUB2022Context LABHUB2022Context)
        {
            this.LABHUB2022Context = LABHUB2022Context;
        }
        // GET: api/<User_Controller>
    
       


        [HttpGet("GetUsers")]
        public async Task<ActionResult<List<C_User>>> Get()
        {
            var List = await LABHUB2022Context.Users.Select(
                s => new C_User
                {
                    Id = s.Id,
                    UserName = s.UserName,
                    PassWord = s.PassWord,
                    FullName = s.FullName,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                    Address = s.Address,
                    Department = s.Department,
                    Position = s.Position,
                    RoleId = s.RoleId,
                    Status = s.Status,
                    IsDeleted = s.IsDeleted,
                    GroupId = s.GroupId,
                    UserType = s.UserType
                  
    }
            ).ToListAsync();

            if (List.Count < 0)
            {
                return NotFound();
            }
            else
            {
                return List;
            }
        }

        // GET api/<User_Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<User_Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<User_Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<User_Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
