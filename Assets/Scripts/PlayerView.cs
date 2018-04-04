using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class PlayerView : MonoBehaviour {
	public GameObject store;
	public GameObject action;

	// private PlayerAction playerAction;
	// private PlayerReducer playerReducer;

	// private Vector3 target;

	// void Start() {
	// 	playerAction = action.GetComponent<PlayerAction>();
	// 	playerReducer = store.GetComponent<PlayerReducer>();

	// 	playerReducer.target.Subscribe( position => target = position );

	// 	this.UpdateAsObservable()
	// 		.Where( _ => transform.position != target)
	// 		.Subscribe( _ => transform.position = Vector3.MoveTowards(transform.position, target, 0.1f) );
		
	// 	this.UpdateAsObservable()
	// 		.Where( _ => Input.GetKeyUp(KeyCode.Space))
	// 		.Subscribe( _ =>  playerAction.MoveTo(new Vector3(10, 0 ,0)));
	// }
}
