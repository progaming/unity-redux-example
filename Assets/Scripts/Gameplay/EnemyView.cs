using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class EnemyView : MonoBehaviour {
		public GameObject redux;
		public Text hpText;

		private Store _store;
		private Action _action;

		void Awake() {
			_action = redux.GetComponent<Action>();
			_store = redux.GetComponent<Store>();
		}

		void Start() {

			_store.Enemy.hp.SubscribeToText(hpText);

			this.UpdateAsObservable()
				.ThrottleFirstFrame(60)
				.Subscribe( _ =>  _action.Fight.Attack(AttackTarget.PLAYER, 1));
		}
	}
}