using System.Dynamic;

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

    public class Action
    {
        public string name;
        public dynamic payload = new ExpandoObject();
        public Action(string name, dynamic payload)
        {
            this.name = name;
            this.payload = payload;
        }
    }
}
