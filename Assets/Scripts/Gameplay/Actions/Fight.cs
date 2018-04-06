using UnityEngine;

namespace ReduxExample.Gameplay.Actions
{
	public class Fight {
		private State _state;

		public Fight(State state){
			_state = state;
		}

		public void Attack(AttackTarget target, int power){
			_state.Dispatch(new AttackAction(target, power));
		}
	}
}

