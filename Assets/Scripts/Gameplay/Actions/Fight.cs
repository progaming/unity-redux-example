using UnityEngine;

namespace ReduxExample.Gameplay.Actions
{
	public class Fight: BaseActionCreator {
		public void Attack(AttackTarget target, int power){
			_store.Dispatch(new AttackAction(target, power));
		}
	}
}

