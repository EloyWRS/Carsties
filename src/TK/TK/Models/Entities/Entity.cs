namespace TK.Models.Entities
{
    public abstract class Entity
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime creation { get; set; }
        public DateTime lastModified { get; set; }
        
    }
}
