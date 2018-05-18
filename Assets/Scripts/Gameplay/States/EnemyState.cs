using UniRx;

namespace ReduxExample.Gameplay
{
    public class EnemyState : IReducer
    {
        public IntReactiveProperty hp = new IntReactiveProperty();

        public EnemyState(int initialHp)
        {
            hp.Value = initialHp;
        }

        public void Reduce(dynamic action)
        {
            switch (action.type as string)
            {
                case "FIGHT_ATTACK":
                    hp.Value = action.payload.target == AttackTarget.ENEMY ? hp.Value - action.payload.power : hp.Value;
                    break;
                default:
                    break;
            }
        }
    }
}