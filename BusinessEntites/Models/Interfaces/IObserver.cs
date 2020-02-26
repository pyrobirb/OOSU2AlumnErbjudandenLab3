namespace BusinessEntites.Models.Interfaces
{
    public interface IObserver//<TEntity> where TEntity : class
    {
        void Update(ISubject subject);
    }
}