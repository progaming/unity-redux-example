using UnityEngine;

namespace ReduxExample.Gameplay
{
    public class Redux : MonoBehaviour
    {
        public Creator creator = new Creator();
        public Store store = new Store();

        void Awake()
        {
            store.Init();
            creator.Init(store);
        }
    }

    public class Store : StoreBase
    {
        public PlayerState Player { get; } = new PlayerState(100);
        public EnemyState Enemy { get; } = new EnemyState(100);
    }

    public class Creator : CreatorBase
    {
        public FightCreator Fight { get; } = new FightCreator();
    }
}

