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
        }

        // GET: api/Fitting
        [HttpGet]
        //[Microsoft.AspNetCore.Cors.EnableCors]
        public IEnumerable<Fitting> Get()
        {
            return _db.GetAllFittings();
        }

        // GET: api/Fitting/MyFitting
        [HttpGet("{fittingName}", Name = "Get")]
        public Fitting Get(string fittingName)
        {
            return _db.GetFitting(fittingName);
        }

        // POST: api/Fitting
        [HttpPost]
        public void Post([FromBody] Fitting fitting)
        {
            //var combatLogEntry1 = new CombatLogEntry();
            //combatLogEntry1.Name = "C1";

            //var combatLogEntry2 = new CombatLogEntry();
            //combatLogEntry2.Name = "C2";

            //fitting.CombatLogEntries.Add(combatLogEntry1);
            //fitting.CombatLogEntries.Add(combatLogEntry2);

            _db.CreateFitting(fitting);
        }

        // PUT: api/Fitting/MyFitting
        [HttpPut("{fittingName}")]
        public void Put(string fittingName, [FromBody] Fitting modifiedFitting)
        {
            _db.UpdateFitting(fittingName, modifiedFitting);
        }

        // DELETE: api/MyFitting/5
        [HttpDelete("{fittingName}")]
        public void Delete(string fittingName)
        {
            _db.DeleteFitting(fittingName);
        }
    }
}
