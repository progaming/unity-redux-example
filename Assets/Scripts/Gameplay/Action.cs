using ReduxExample.Gameplay.Actions;

namespace ReduxExample.Gameplay {
    public class Action : BaseCreator {
		public Fight Fight {get;} = new Fight();
    }
}