using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

using ReduxExample.Gameplay;
using ReduxExample.Gameplay.Actions;

public class UnitTest : MonoBehaviour {

	[Test]
	public static void AlwaysPass() 
    {
        Assert.That(true);
	}

	[Test]
	public static void AttackEnemy()
	{
		GameObject redux = new GameObject();
		Creator creator = new Creator();
		Store store = new Store();

		store.Init();
		creator.Init(store);
		creator.Fight.Attack(AttackTarget.ENEMY, 10);
		
		Assert.That(store.Enemy.hp.Value == 90);
	}
}