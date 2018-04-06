using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispatcherBase {
	protected StoreBase _store;
	public void Init(StoreBase store){
		_store = store;
	}

	protected void Dispatch(object payload){
		_store.Dispatch(payload);
	}
}
