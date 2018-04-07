using UniRx;
using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay.States {
	public class EnemyState : IReducer {
		public IntReactiveProperty hp = new IntReactiveProperty();

		public EnemyState(int initialHp){
			hp.Value = initialHp;
		}
		
		public void Reduce(object payload){
			ActionBase action = payload as ActionBase;
			switch(action.name){
				case "ATTACK":
					AttackAction attackAction = payload as AttackAction;
					hp.Value = attackAction.target == AttackTarget.ENEMY ? hp.Value - attackAction.power : hp.Value;
					break;
				default:
					break;
			} 
		}
	}
}