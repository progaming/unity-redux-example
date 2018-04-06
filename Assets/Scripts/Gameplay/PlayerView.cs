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
		private Creator _creator;

		void Awake() {
			_creator = redux.GetComponent<Creator>();
			_store = redux.GetComponent<Store>();
		}

		void Start() {
			_store.Player.hp.SubscribeToText(hpText);
			
			this.UpdateAsObservable()
				.Where( _ => Input.GetKeyUp(KeyCode.Space))
				.Where( _ => _store.Enemy.hp.Value > 0)
				.Subscribe( _ =>  _creator.Fight.Attack(AttackTarget.ENEMY, 1));
		}
	}
}

