using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private static List<Doctor> doctor = new List<Doctor> {
            new Doctor { id = 1, name = "david",pone=0556761152,emil = "hi@email.com",businesshours=7 } ,
            new Doctor { id = 2, name = "david",pone=0556761152,emil = "hi@email.com",businesshours=7 } ,
            new Doctor { id = 3, name = "david",pone=0556761152,emil = "hi@email.com",businesshours=7 } };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return doctor;
        }

        [HttpPost]
        public Doctor Post([FromBody] Doctor value)
        {
            doctor.Add(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            var index=doctor.FindIndex(x=>x.Id==id);
            doctor[index].Id = value.id;
            doctor[index].Email = value.emil;
            doctor[index].Name = value.name;
            doctor[index].Pone = value.pone;
            doctor[index].Businesshours = value.businesshours;

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index=doctor.FindIndex(x => x.Id == id);
            doctor.Remove(doctor[index]);
        }
    }
}
