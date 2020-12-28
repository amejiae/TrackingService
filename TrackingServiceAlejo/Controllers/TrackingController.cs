using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using TrackingServiceAlejo.Model;

namespace TrackingServiceAlejo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackingController : ControllerBase
    {
        private readonly IDataRepository<Tracking> _dataRepository;

        public TrackingController(IDataRepository<Tracking> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET: api/Tracking/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Tracking tracking = _dataRepository.Get(id);

            if (tracking == null)
            {
                return NotFound("The tracking record couldn't be found.");
            }

            return Ok(tracking);
        }

        // POST: api/Tracking
        [HttpPost]
        public IActionResult Post([FromBody] LocationBatch batch)
        {
            if (batch == null)
            {
                return BadRequest("Tracking is null.");
            }
            
            var trackings = new List<Tracking>();
            foreach (var location in batch.Locations)
            {
                var newTracking = new Tracking
                {
                    Longitude = location.Geometry.Coordinates[0],
                    Lattitude = location.Geometry.Coordinates[1],
                    DeviceId = location.Properties.device_id
                };

                trackings.Add(newTracking);
            }

            _dataRepository.AddRange(trackings);

            JsonResponse jsonResponse = new JsonResponse {Result = "ok"};
            var jsonResult = new JsonResult(jsonResponse);
            return jsonResult;
        }
    }

    public class JsonResponse
    {
        public string Result { get; set; }
    }
}
