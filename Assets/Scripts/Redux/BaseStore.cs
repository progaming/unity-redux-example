using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BaseStore : MonoBehaviour {
	private List<IReducer> _reducers;
	protected void Awake(){
		_reducers = this.GetType().GetProperties()
			// Include only the properties that implement IReducer
			.Where(prop => prop.PropertyType.GetInterfaces().Contains(typeof(IReducer)))
			// Cast to IReducer and convert them to list
			.Select(prop => prop.GetValue(this) as IReducer)
			.ToList();
	}
	public void Dispatch(object payload){
		_reducers.ForEach(r => r.Reduce(payload));
	}
}
