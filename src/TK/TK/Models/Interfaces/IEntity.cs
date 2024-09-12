namespace TK.Models.Interfaces
{
    public interface IEntity
    {
        Task<Guid> GetID();
    }
}
