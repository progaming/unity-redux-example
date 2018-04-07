using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

namespace ReduxExample.Gameplay
{
    public class EnemyView : MonoBehaviour
    {
        public Redux redux;
        public Text hpText;

        void Start()
        {
            redux.store.Enemy.hp.SubscribeToText(hpText);

            this.UpdateAsObservable()
                .ThrottleFirstFrame(60)
                .Subscribe(_ => redux.creator.Fight.Attack(AttackTarget.PLAYER, 1));
        }
    }
}