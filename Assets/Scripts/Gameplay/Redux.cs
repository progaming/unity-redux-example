using UnityEngine;

namespace ReduxExample.Gameplay
{
    public class Redux : MonoBehaviour
    {
        public Store store;
        public Creator creator;

        void Awake()
        {
            store = new Store();
            creator = new Creator();
            store.Init();
            creator.Init(store);
        }
    }

    public class Store : StoreBase
    {
        public readonly PlayerState Player = new PlayerState(100);
        public readonly EnemyState Enemy = new EnemyState(100);
    }

    public class Creator : CreatorBase
    {
        public readonly FightCreator Fight = new FightCreator();
    }
}

