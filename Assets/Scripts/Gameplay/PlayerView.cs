using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class PlayerView : MonoBehaviour {
		public GameObject redux;
		public Text hpText;

		private State _state;
		private Action _action;

		void Awake() {
			_action = redux.GetComponent<Action>();
			_state = redux.GetComponent<State>();
		}

		void Start() {
			_state.Player.hp.SubscribeToText(hpText);
			
			this.UpdateAsObservable()
				.Where( _ => Input.GetKeyUp(KeyCode.Space))
				.Where( _ => _state.Enemy.hp.Value > 0)
				.Subscribe( _ =>  _action.Fight.Attack(AttackTarget.ENEMY, 1));
		}
	}
}

