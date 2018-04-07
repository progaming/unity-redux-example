using UnityEngine;

namespace ReduxExample.Gameplay
{
	#region types
	public enum AttackTarget{
		PLAYER,
		ENEMY
	}

	public class FightAttack: ActionBase {
		public AttackTarget target;
		public int power;
		
		public FightAttack(AttackTarget target, int power){
			this.name = "FIGHT_ATTACK";
			this.target = target;
			this.power = power;
		}
	}
	#endregion

	#region dispatchers
	public class FightCreator: DispatcherBase {
		public void Attack(AttackTarget target, int power){
			Dispatch(new FightAttack(target, power));
		}
	}
	#endregion
}