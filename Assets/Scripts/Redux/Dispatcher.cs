using UnityEngine;

public class Dispatcher : MonoBehaviour {
	public void Dispatch(object payload){
		gameObject.SendMessage("Reduce", payload);
	}
}
