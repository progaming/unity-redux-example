using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class PlayerView : MonoBehaviour {
		public Creator creator;
		public Store store;
		public Text hpText;

		void Start() {
			store.Player.hp.SubscribeToText(hpText);
			
			this.UpdateAsObservable()
				.Where( _ => Input.GetKeyUp(KeyCode.Space))
				.Where( _ => store.Enemy.hp.Value > 0)
				.Subscribe( _ =>  creator.Fight.Attack(AttackTarget.ENEMY, 1));
		}
	}
}

