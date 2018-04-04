using UnityEngine;
using UniRx;

public class Enemy : MonoBehaviour {
	public IntReactiveProperty hp;

	void Start(){
		hp.Value = 100;
	}

	void Reduce(object payload){
		BaseAction baseAction = payload as BaseAction;
		switch(baseAction.name){
			case "ATTACK":
				AttackAction action = payload as AttackAction;
				hp.Value = action.target == AttackTarget.ENEMY ? hp.Value - action.power : hp.Value;
				break;
			default:
				break;
		} 
	}
}
