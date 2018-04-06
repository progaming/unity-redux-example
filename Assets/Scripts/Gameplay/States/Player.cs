using UniRx;
using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay.States {
	public class Player : IReducer {
		public IntReactiveProperty hp = new IntReactiveProperty();

		public Player(int initialHp){
			hp.Value = initialHp;
		}
		
		public void Reduce(object payload){
			ActionBase action = payload as ActionBase;
			switch(action.name){
				case "ATTACK":
					AttackAction attackAction = payload as AttackAction;
					hp.Value = attackAction.target == AttackTarget.PLAYER ? hp.Value - attackAction.power : hp.Value;
					break;
				default:
					break;
			} 
		}
	}
}
