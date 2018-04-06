using UnityEngine;

namespace ReduxExample.Gameplay.Actions
{
	#region types
	public enum AttackTarget{
		PLAYER,
		ENEMY
	}

	public class AttackAction: ActionBase {
		public AttackTarget target;
		public int power;
		
		public AttackAction(AttackTarget target, int power){
			this.name = "ATTACK";
			this.target = target;
			this.power = power;
		}
	}
	#endregion

	#region dispatchers
	public class Fight: DispatcherBase {
		public void Attack(AttackTarget target, int power){
			Dispatch(new AttackAction(target, power));
		}
	}
	#endregion
}