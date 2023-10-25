using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static tema_lab2.Studenti;

namespace tema_lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class StudentsController : ControllerBase
        {
            public static List<Studenti> students = new List<Studenti>
        {
            new Studenti { Id = 1, Name = "Mihai", Age = 50 },
            new Studenti { Id = 1, Name = "Cosmin", Age = 40},
            new Studenti { Id = 1, Name = "Tudor", Age = 30},
        };

        // endpoint 
        // Get 
 
        /*[HttpGet]
        public List<Studenti> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }*/

        [HttpGet]
        public List<Studenti>getAllOrdered()
        {
            return students.OrderBy(o => o.Name).ToList();
        }


        [HttpPost]
        public List<Studenti> Add(Studenti student)
        {
            students.Add(student);
            return students;
        }


        /*[HttpDelete]
        public List<Studenti> Delete(Studenti student)
        {
            var studentIndex = students.FindIndex(x => x.Id == student.Id);
            students.RemoveAt(studentIndex);
            return students;
        }*/

        [HttpDelete]

        public List<Studenti> NewDelete(Studenti student)
        {
            var studentIndex = students.FindIndex(x => x.Age == student.Age);
            students.RemoveAt(studentIndex);
            return students;
        }
    }
    }
