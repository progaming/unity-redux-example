using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using ReduxExample.Gameplay.States;

namespace ReduxExample.Gameplay {
	public class Store : BaseStore {
		public Player Player {get;} = new Player(100);
		public Enemy Enemy {get;} = new Enemy(100);
	}
}
