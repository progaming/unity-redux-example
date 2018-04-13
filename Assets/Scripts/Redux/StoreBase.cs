using System.Collections.Generic;
using System.Linq;

public class StoreBase
{
    private List<IReducer> _reducers;
    public void Init()
    {
        _reducers = this.GetType().GetFields()
            // Include only the properties that implement IReducer
            .Where(f => f.GetValue(this).GetType().GetInterfaces().Contains(typeof(IReducer)))
            // Cast to IReducer and convert them to list
            .Select(f => f.GetValue(this) as IReducer)
            .ToList();
    }
    public void Dispatch(object payload)
    {
        _reducers.ForEach(r => r.Reduce(payload));
    }
}
