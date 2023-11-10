using lab4.Data;
using lab4.Models.DTOs;
using lab4.Models.One_to_Many;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab4.Controllers
{
    public class DataBaseController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class DatabaseController : ControllerBase
        {
            private readonly Lab4Context _lab4Context;

            public DatabaseController(Lab4Context lab4Context)
            {
                _lab4Context = lab4Context;
            }

            [HttpGet("Facultate")]
            public async Task<IActionResult> GetModel1()
            {
                return Ok(await _lab4Context.Facultati.ToListAsync());
            }

            [HttpPost("model1")]
            public async Task<IActionResult> Create(FacultateDTO facultateDTO)
            {
                var newModel1 = new Facultate
                {
                    Id = Guid.NewGuid(),
                    Name = facultateDTO.Name
                };

                await _lab4Context.AddAsync(newModel1);
                await _lab4Context.SaveChangesAsync();

                return Ok(newModel1);
            }

            [HttpPost("update")]
            public async Task<IActionResult> Update(FacultateDTO facultateDTO)
            {
                Facultate model1ById = await _lab4Context.Facultati.FirstOrDefaultAsync(x => x.Id == facultateDTO.Id);
                if (model1ById == null)
                {
                    return BadRequest("Object does not exist");
                }

                model1ById.Name = facultateDTO.Name;
                _lab4Context.Update(model1ById);
                await _lab4Context.SaveChangesAsync();

                return Ok(model1ById);
            }
        }
    }
}
