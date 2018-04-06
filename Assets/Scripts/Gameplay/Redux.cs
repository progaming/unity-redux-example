using UnityEngine;
using ReduxExample.Gameplay.Actions;
using ReduxExample.Gameplay.States;

namespace ReduxExample.Gameplay {
	public class Redux : MonoBehaviour {
		public Creator creator = new Creator();
		public Store store = new Store();
		
		void Awake () {
			store.Init();
			creator.Init(store);
		}
	}
	
	public class Store : BaseStore {
		public Player Player {get;} = new Player(100);
		public Enemy Enemy {get;} = new Enemy(100);
	}

	public class Creator : BaseCreator {
		public Fight Fight {get;} = new Fight();
	}
}

