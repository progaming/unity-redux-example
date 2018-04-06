using UnityEngine;

namespace ReduxExample.Gameplay.Actions
{
	public class Fight: BaseDispatcher {
		public void Attack(AttackTarget target, int power){
			Dispatch(new AttackAction(target, power));
		}
	}
}