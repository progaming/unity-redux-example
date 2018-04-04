using UnityEngine;

public class ActionCreator : MonoBehaviour {
	public Dispatcher dispatcher;

	public void Attack(AttackTarget target, int power){
		dispatcher.Dispatch(new AttackAction(target, power));
	}
}
