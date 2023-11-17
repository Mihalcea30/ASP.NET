using lab4.Data;
using lab4.Models;
using lab4.Models.DTOs;
using lab4.Models.One_to_Many;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab4.Controllers
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

        [HttpGet("model1")]
        public async Task<IActionResult> GetModel1()
        {
            return Ok(await _lab4Context.Facultati.ToListAsync());
        }

        [HttpPost("model1")]
        public async Task<IActionResult> Create(FacultateDTO model1Dto)
        {
            var newModel1 = new Facultate
            {
                Id = Guid.NewGuid(),
                Name = model1Dto.Name
            };

            await _lab4Context.AddAsync(newModel1);
            await _lab4Context.SaveChangesAsync();

            return Ok(newModel1);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(FacultateDTO model1Dto)
        {
            Facultate model1ById = await _lab4Context.Facultati.FirstOrDefaultAsync(x => x.Id == model1Dto.Id);
            if (model1ById == null)
            {
                return BadRequest("Object does not exist");
            }

            model1ById.Name = model1Dto.Name;
            _lab4Context.Update(model1ById);
            await _lab4Context.SaveChangesAsync();

            return Ok(model1ById);
        }

        [HttpGet("model2")]
        public async Task<IActionResult> GetModel2()
        {
            return Ok(await _lab4Context.Universitati.ToListAsync());
        }

        [HttpPost("model2")]
        public async Task<IActionResult> Create(UniversitateDTO model2Dto)
        {
            var newModel2 = new Facultate
            {
                Id = Guid.NewGuid(),
                Name = model2Dto.Name
            };

            await _lab4Context.AddAsync(newModel2);
            await _lab4Context.SaveChangesAsync();

            return Ok(newModel2);
        }

        [HttpPost("update2")]
        public async Task<IActionResult> Update(UniversitateDTO model2Dto)
        {
            Facultate model2ById = await _lab4Context.Facultati.FirstOrDefaultAsync(x => x.Id == model2Dto.Id);
            if (model2ById == null)
            {
                return BadRequest("Object does not exist");
            }

            model2ById.Name = model2Dto.Name;
            _lab4Context.Update(model2ById);
            await _lab4Context.SaveChangesAsync();

            return Ok(model2ById);
        }
        public List<Universitate> GetAllWithInclude()
        {

            var result = _lab4Context.Universitati.Include(s => s.Facultati).ThenInclude(m2 => m2.Universitate).ToList();
            return (List<Universitate>)_lab4Context.Universitati.Include(s => s.Facultati.ToList());

            // Model1 model1-a
            // Model2 model2-a
            // {...model1-a, {... model2 a}}
        }

        public List<dynamic> GetAllWithJoin()
        {
            var result = _lab4Context.Universitati.Join(_lab4Context.Facultati, model1 => model1.Id, model2 => model2.UniversitateId,
                (model1, model2) => new { model1, model2 }).Select(ob => ob.model1);


            // model1, model
            // {...model1-a, model2-a}, {...model1-b, ...model2-b}

            return null;
        }

    }
}
