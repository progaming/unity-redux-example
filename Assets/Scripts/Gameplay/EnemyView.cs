using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class EnemyView : MonoBehaviour {
		public GameObject redux;
		public Text hpText;

		private State _state;
		private Action _action;

		void Awake() {
			_action = redux.GetComponent<Action>();
			_state = redux.GetComponent<State>();
		}

		void Start() {

			_state.Enemy.hp.SubscribeToText(hpText);

			this.UpdateAsObservable()
				.ThrottleFirstFrame(60)
				.Subscribe( _ =>  _action.Fight.Attack(AttackTarget.PLAYER, 1));
		}
	}
}