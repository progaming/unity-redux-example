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

        public void Reduce(object payload)
        {
            ActionBase action = payload as ActionBase;
            switch (action.name)
            {
                case "FIGHT_ATTACK":
                    FightAttack fightAttack = payload as FightAttack;
                    hp.Value = fightAttack.target == AttackTarget.ENEMY ? hp.Value - fightAttack.power : hp.Value;
                    break;
                default:
                    break;
            }
        }
    }
}