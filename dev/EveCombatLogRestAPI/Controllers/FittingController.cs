using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EveCombatLogModel;

namespace EveCombatLogRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FittingController : ControllerBase
    {
        private IDBHelper _db;

        public FittingController(IDBHelper db)
        {
            _db = db;
            //_db.Init();
        }

        // GET: api/Fitting
        [HttpGet]
        public IEnumerable<Fitting> Get()
        {
            //return new string[] { "value1", "value2" };
            return _db.GetAllFittings();
        }

        // GET: api/Fitting/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(string id)
        {
            return _db.GetFitting(id).ToString();
        }

        // POST: api/Fitting
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var insert = new Fitting
            {
                Name = value
            };
            _db.CreateFitting(insert);
        }

        // PUT: api/Fitting/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
