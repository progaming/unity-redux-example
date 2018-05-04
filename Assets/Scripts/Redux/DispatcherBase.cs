using System.Dynamic;

public class DispatcherBase
{
    protected StoreBase store;
    public void Init(StoreBase store)
    {
        this.store = store;
    }

    protected void Dispatch(dynamic action)
    {
        store.Dispatch(action);
    }
}
