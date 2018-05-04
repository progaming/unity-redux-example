using System.Linq;

public class CreatorBase
{
    public void Init(StoreBase store)
    {
        var creators = this.GetType().GetFields()
            .Where(f => f.GetValue(this).GetType().IsSubclassOf(typeof(DispatcherBase)))
            .Select(f => f.GetValue(this) as DispatcherBase)
            .ToList();

        creators.ForEach(c => c.Init(store));
    }
}
