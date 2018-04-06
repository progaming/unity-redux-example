using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseActionCreator : MonoBehaviour {
	protected BaseStore _store;
	public void Init(BaseStore store){
		_store = store;
	}
}
