using UniRx;
using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay.States {
	public class Player : IReducer {
		public IntReactiveProperty hp = new IntReactiveProperty();

		public Player(int initialHp){
			hp.Value = initialHp;
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
}
