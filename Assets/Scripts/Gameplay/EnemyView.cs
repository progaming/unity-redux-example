using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
	public class EnemyView : MonoBehaviour {
		public Creator creator;
		public Store store;
		public Text hpText;

		void Start() {
			store.Enemy.hp.SubscribeToText(hpText);

			this.UpdateAsObservable()
				.ThrottleFirstFrame(60)
				.Subscribe( _ =>  creator.Fight.Attack(AttackTarget.PLAYER, 1));
		}
	}
}