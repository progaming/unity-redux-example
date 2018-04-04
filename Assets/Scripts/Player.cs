using UnityEngine;
using UniRx;

public class Player : MonoBehaviour, IReducer {
	public IntReactiveProperty hp;

	void Start(){
		hp.Value = 100;
	}

	public void Reduce(object payload){
		BaseAction baseAction = payload as BaseAction;
		switch(baseAction.name){
			case "ATTACK":
				AttackAction action = payload as AttackAction;
				hp.Value = action.target == AttackTarget.PLAYER ? hp.Value - action.power : hp.Value;
				break;
			default:
				break;
		} 
	}
}
