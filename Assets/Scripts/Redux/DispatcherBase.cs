public class DispatcherBase
{
    protected StoreBase _store;
    public void Init(StoreBase store)
    {
        _store = store;
    }

    protected void Dispatch(dynamic action)
    {
        _store.Dispatch(action);
    }
}
