using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class PlayerView : MonoBehaviour {
		public GameObject redux;
		public Text hpText;

		private Store _store;
		private Action _action;

		void Awake() {
			_action = redux.GetComponent<Action>();
			_store = redux.GetComponent<Store>();
		}

		void Start() {
			_store.Player.hp.SubscribeToText(hpText);
			
			this.UpdateAsObservable()
				.Where( _ => Input.GetKeyUp(KeyCode.Space))
				.Where( _ => _store.Enemy.hp.Value > 0)
				.Subscribe( _ =>  _action.Fight.Attack(AttackTarget.ENEMY, 1));
		}
	}
}

