using UniRx;

namespace ReduxExample.Gameplay
{
    public class PlayerState : IReducer
    {
        public IntReactiveProperty hp = new IntReactiveProperty();

        public PlayerState(int initialHp)
        {
            hp.Value = initialHp;
        }

        public void Reduce(dynamic action)
        {
            switch (action.name as string)
            {
                case "FIGHT_ATTACK":
                    hp.Value = action.payload.target == AttackTarget.PLAYER ? hp.Value - action.payload.power : hp.Value;
                    break;
                default:
                    break;
            }
        }
    }
}
