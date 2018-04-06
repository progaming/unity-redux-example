using UnityEngine;

namespace ReduxExample.Gameplay.Actions
{
	public class Fight {
		private Store _store;

		public Fight(Store store){
			_store = store;
		}

		public void Attack(AttackTarget target, int power){
			_store.Dispatch(new AttackAction(target, power));
		}
	}
}

