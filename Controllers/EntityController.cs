using Microsoft.AspNetCore.Mvc;
using Project.Codes.Services;

namespace Project.Controllers
{
    public class EntityUpdateRequest
    {
        public string ModelName { get; set; }
        public int EntityId { get; set; }
        public Dictionary<string, object> UpdatedColumns { get; set; }
    }
    public class EntityUpdateDto
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }



    public class EntityController : Controller
    {
        

        private readonly IEntityService _entityService;

        public EntityController(IEntityService entityService)
        {
            _entityService = entityService;
        }

        [HttpPost]
        public JsonResult GetModels(string modelName)
        {
            var models = _entityService.GetEntities(modelName);

            if (models != null)
            {
                return Json(models);
            }

            return Json(new { error = "Model not found" });
        }

        [HttpPost]
        public JsonResult GetEntityDetail(string modelName, int entityId)
        {
            var entityDetail = _entityService.GetEntityDetail(modelName, entityId);

            if (entityDetail != null)
            {
                return Json(entityDetail);
            }

            return Json(new { error = "Entity not found" });
        }
        [HttpPost]
        public JsonResult DeleteEntity(string modelName, int entityId)
        {
            var isDeleted = _entityService.DeleteEntity(modelName, entityId);

            if (isDeleted)
            {
                return Json(new { success = true });
            }

            return Json(new { error = "Entity not found or could not be deleted" });
        }
        [HttpPost]
        public IActionResult UpdateEntity([FromBody] EntityUpdateRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            bool result = _entityService.UpdateEntity(request.ModelName, request.EntityId, request.UpdatedColumns);

            if (result)
            {
                return Ok("Entity updated successfully.");
            }
            else
            {
                return BadRequest("Failed to update entity.");
            }
        }

    }
}
