using UnityEngine;
using ReduxExample.Gameplay;

public class Redux : MonoBehaviour {
	public Creator creator = new Creator();
	public Store store = new Store();
	
	void Start () {
		store.Init();
		creator.Init(store);
	}
}
