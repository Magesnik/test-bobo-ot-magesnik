using Microsoft.AspNetCore.Mvc;
using PetClinic;
using AnimalServices;

namespace CodeRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalzController : ControllerBase
    {
        private DbThingy db;
        private AnimalService servicer;

        public AnimalzController(DbThingy d, AnimalService s)
        {
            db = d;
            servicer = s;
        }

        [HttpPost("add")]
        public string AddAnimal([FromQuery] string name, string owner, ushort age, string type)
        {
            servicer.AddNewAnimal(name, owner, age, type);
            return "200 OK animal added";
        }

        [HttpPost("heal/{id}")]
        public string HealAnimal(int id)
        {
            servicer.DoHeal(id);
            return "Animal is healed and status code 200";
        }

        [HttpDelete("delete/{id}")]
        public string DeleteAnimal(int id)
        {
            db.Remove(id);
            return "removed id";
        }

        [HttpPost("ageup")]
        public string AgeUp()
        {
            servicer.RandomAgeUp();
            return "everyone got older.";
        }
    }
}
