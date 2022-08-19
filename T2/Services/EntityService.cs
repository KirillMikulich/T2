using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using T2.Interfaces.Services;
using Kind = T2.Entities.Entity;

namespace T2.Services
{
    public class EntityService : IEntityService
    {
        private static List<Kind> entities = new List<Kind>();

        public Kind Add(string value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();

            var entity = JsonSerializer.Deserialize<Kind>(value);

            entities.Add(entity);

            return entity;
        }

        public string Get(Guid id)
        {
            var findedElement = entities.FirstOrDefault(x => x.Id == id);
            return JsonSerializer.Serialize(findedElement);
        }
    }
}
