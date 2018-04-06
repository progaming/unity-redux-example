using ReduxExample.Gameplay.States;
using UnityEngine;

namespace ReduxExample.Gameplay {
	public class State : MonoBehaviour {
		public Player Player {get;} = new Player(100);
		public Enemy Enemy {get;} = new Enemy(100);

		public void Dispatch(object payload){
			Player.Reduce(payload);
			Enemy.Reduce(payload);
		}
	}
}
