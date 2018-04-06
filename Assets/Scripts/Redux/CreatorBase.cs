using System;
using System.Linq;
using UnityEngine;

public class CreatorBase {
	public void Init(StoreBase store){
		var _creators = this.GetType().GetProperties()
			.Where(prop => prop.PropertyType.IsSubclassOf(typeof(DispatcherBase)))
			.Select(prop => prop.GetValue(this) as DispatcherBase)
			.ToList();

		_creators.ForEach(c => c.Init(store));
	}
}
