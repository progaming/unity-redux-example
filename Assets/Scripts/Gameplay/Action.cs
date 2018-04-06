using ReduxExample.Gameplay.Actions;
using UnityEngine;

namespace ReduxExample.Gameplay {
    public class Action : MonoBehaviour {
			public State state;
			public Fight Fight {get; private set;}

			public void Awake(){
				Fight = new Fight(state);
			}
    }
}


