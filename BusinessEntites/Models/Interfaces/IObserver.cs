namespace BusinessEntites.Models.Interfaces
{
    public interface IObserver//<TEntity> where TEntity : class
    {
        void UpdateNewMessage(int AnvID, bool newMessage);

    }
}