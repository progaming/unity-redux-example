using UniRx;
using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay.States {
	public class PlayerState : IReducer {
		public IntReactiveProperty hp = new IntReactiveProperty();

		public PlayerState(int initialHp){
			hp.Value = initialHp;
		}
		
		public void Reduce(object payload){
			ActionBase action = payload as ActionBase;
			switch(action.name){
				case "FIGHT_ATTACK":
					FightAttack fightAttack = payload as FightAttack;
					hp.Value = fightAttack.target == AttackTarget.PLAYER ? hp.Value - fightAttack.power : hp.Value;
					break;
				default:
					break;
			} 
		}
	}
}
