using Kind = T2.Entities.Entity;

namespace T2.Interfaces.Services
{
    public interface IEntityService
    {
        public Kind Add(string value);
        public string Get(Guid id);
    }
}
