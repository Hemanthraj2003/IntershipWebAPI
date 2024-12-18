using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntershipWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<DummyModel> DataList = new List<DummyModel>();

        [HttpPost]
        public IActionResult Post([FromBody] DummyModel model)
        {
            DataList.Add(model);
            return Ok("Data Stored Successfully");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DataList);
        }

        [HttpPut]
        public IActionResult Put(string name, DummyModel model) {
            var checkExist = DataList.Find(c => c.Name == name);
            if (checkExist == null) { 
                return NotFound("Data not Found");
            }
            else
            {
                checkExist.Name = model.Name;
                checkExist.Description = model.Description;
                return Ok(checkExist);

            }
        }

        [HttpDelete]
        public IActionResult Delete(int Id) {

            var isExisting = DataList.Find(c => c.Id == Id);
            if (isExisting == null)
            {
                return NotFound("Data not Found");
            }
            else
            { 
                return Ok(DataList.Remove(isExisting));
            }
        }
    }
    public class DummyModel { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
