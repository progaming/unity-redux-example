﻿using System;
using System.Linq;
using UnityEngine;

public class BaseCreator : MonoBehaviour {
	protected void Awake(){
		BaseStore store = GetComponent<BaseStore>();

		var _creators = this.GetType().GetProperties()
			.Where(prop => prop.PropertyType.IsSubclassOf(typeof(BaseDispatcher)))
			.Select(prop => prop.GetValue(this) as BaseDispatcher)
			.ToList();

		_creators.ForEach(c => c.Init(store));
	}
}