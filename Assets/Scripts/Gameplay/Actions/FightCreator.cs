using System.Dynamic;
using UnityEngine;

namespace ReduxExample.Gameplay
{
    public enum AttackTarget
    {
        PLAYER,
        ENEMY
    }

    public class FightCreator : DispatcherBase
    {
        public void Attack(AttackTarget target, int power)
        {
            dynamic payload = new ExpandoObject();
            payload.target = target;
            payload.power = power;

            Dispatch(new Action("FIGHT_ATTACK", payload));
        }
    }
}