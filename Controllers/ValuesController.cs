using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppTelerikGridSkipBug
{
    public partial class GridData
    {
        public List<Row> Rows { get; set; }
    }

    public partial class Row
    {
        public int Id { get; set; }
        public string Ordnungszahl { get; set; }
        public string Kurztext { get; set; }
        public string Langtext { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("Get")]
        public ActionResult<GridData> Get()
        {
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<GridData>(
                System.IO.File.ReadAllText(@"GridData.json"));

            return Ok(result);
        }
    }
}
