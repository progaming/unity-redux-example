using System.Collections.Generic;
using System.Linq;

public class StoreBase
{
    private IMiddleware[] middlewares;
    private List<IReducer> reducers;

    public void Init(params IMiddleware[] middlewares)
    {
        this.middlewares = middlewares;
        reducers = this.GetType().GetFields()
            // Include only the properties that implement IReducer
            .Where(f => f.GetValue(this).GetType().GetInterfaces().Contains(typeof(IReducer)))
            // Cast to IReducer and convert them to list
            .Select(f => f.GetValue(this) as IReducer)
            .ToList();
    }
    public void Dispatch(dynamic action)
    {
        middlewares.ToList().ForEach(m => action = m.Apply(action));
        reducers.ForEach(r => r.Reduce(action));
    }
}
