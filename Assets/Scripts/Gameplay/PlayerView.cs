using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class PlayerView : MonoBehaviour {
		public Redux redux;
		public Text hpText;

		void Start() {
			redux.store.Player.hp.SubscribeToText(hpText);
			
			this.UpdateAsObservable()
				.Where( _ => Input.GetKeyUp(KeyCode.Space))
				.Where( _ => redux.store.Enemy.hp.Value > 0)
				.Subscribe( _ =>  redux.creator.Fight.Attack(AttackTarget.ENEMY, 1));
		}
	}
}

