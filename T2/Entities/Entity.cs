using System.Text.Json.Serialization;

namespace T2.Entities
{
    public class Entity
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("operationDate")]
        public DateTime OperationDate { get; set; }
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        public Entity()
        {
            this.Id = Guid.NewGuid();
            this.OperationDate = DateTime.Now;
        }
    }
}
