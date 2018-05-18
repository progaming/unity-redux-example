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
            Dispatch(new {
                type = "FIGHT_ATTACK",
                payload = new {
                    target,
                    power
                }
            });
            // This can be done with ExpandoObject as well
            /* 
            dynamic payload = new ExpandoObject();
            payload.target = target;
            payload.power = power;

            dynamic action = new ExpandoObject();
            action.type = "FIGHT_ATTACK";
            action.payload = payload;

            Dispatch(action);
            */
        }
    }
}