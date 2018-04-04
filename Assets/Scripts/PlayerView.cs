using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class PlayerView : MonoBehaviour {
	public GameObject store;
	public GameObject action;

	public Text hpText;

	private ActionCreator _actionCreator;
	private Player _player;

	void Start() {
		_player = store.GetComponent<Player>();
		_actionCreator = action.GetComponent<ActionCreator>();

		_player.hp.SubscribeToText(hpText);
		
		this.UpdateAsObservable()
			.Where( _ => Input.GetKeyUp(KeyCode.Space))
			.Subscribe( _ =>  _actionCreator.Attack(AttackTarget.ENEMY, 1));
	}
}
