using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDispatcher {
	protected BaseStore _store;
	public void Init(BaseStore store){
		_store = store;
	}

	protected void Dispatch(object payload){
		_store.Dispatch(payload);
	}
}
