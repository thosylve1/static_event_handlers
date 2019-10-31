namespace StaticEventHandlers
{
    public interface IHandle<T>
    {
        void Handle(T msg);
    }
}