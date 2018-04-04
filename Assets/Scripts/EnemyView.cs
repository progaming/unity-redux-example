using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class EnemyView : MonoBehaviour {
	public GameObject store;
	public GameObject action;

	public Text hpText;

	private ActionCreator _actionCreator;
	private Enemy _enemy;

	void Start() {
		_enemy = store.GetComponent<Enemy>();
		_actionCreator = action.GetComponent<ActionCreator>();

		_enemy.hp.SubscribeToText(hpText);

		this.UpdateAsObservable()
			.ThrottleFirstFrame(60)
			.Subscribe( _ =>  _actionCreator.Attack(AttackTarget.PLAYER, 1));
	}
}