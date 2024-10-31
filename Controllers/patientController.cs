using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projecctclilnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static List<Patient> patient = new List<Patient> {
            new Patient { id = 1, name = "david",pone=0556761152,emil = "hi@email.com",address="rabi akiva",city="bny brk"} ,
            new Patient { id = 2, name = "david",pone=0556761152,emil = "hi@email.com",address="rabi akiva",city="bny brk"} ,
            new Patient { id = 3, name = "david",pone=0556761152,emil = "hi@email.com",address="rabi akiva",city="bny brk" } };
        // GET: api/<patientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patient;
        }
        // POST api/<patientController>
        [HttpPost]
        public Patient Post([FromBody] Patient value)
        {
            patient.Add(value);
            return value;
        }

        // PUT api/<patientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            var index = patient.FindIndex(x => x.Id == id);
            patient[index].Id = value.id;
            patient[index].Email = value.emil;
            patient[index].Name = value.name;
            patient[index].Pone = value.pone;
            patient[index].City = value.city;
            patient[index].Address = value.address;

        }

        // DELETE api/<patientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = patient.FindIndex(x => x.Id == id);
            patient.Remove(patient[index]);
        }
    }
}
