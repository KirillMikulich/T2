using Microsoft.AspNetCore.Mvc;
using T2.Interfaces.Services;
using T2.Services;

namespace T2.Controllers
{
    [Route("api/entities")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IEntityService _service;
            
        public EntityController(IEntityService service)
        {
            _service = new EntityService();
        }

        /// <summary>
        /// Insert new Json object to list
        /// </summary>
        /// <param name="data"> Object type of Entity { id: Guid, operationDate: DateTime, amount: Decimal}
        /// {"id":"cfaa0d3f-7fea-4423-9f69-ebff826e2f89","operationDate":"2019-07-26T00:00:00","amount":23.05}</param>
        /// <returns></returns>
        [HttpPost]
        [Route("insert")]
        public IActionResult Insert([FromQuery] string data)
        {
            var newItem = _service.Add(data);
            return Ok(newItem);
        }

        /// <summary>
        /// Get Json object by id
        /// </summary>
        /// <param name="id">Type: Guid, id entity of list</param>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        public IActionResult Get([FromQuery] Guid id)
        {
            var item = _service.Get(id);

            return Ok(item);
        }
    }
}
