using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetDataOfUsersController : ControllerBase
    {
        private DataContext _cont;

        public GetDataOfUsersController(DataContext cont)
        {
            _cont=cont;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetData(){

            return await _cont.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUsers>> GetSpecificData(int id){

            return await _cont.Users.FindAsync(id);
        }
    }
}