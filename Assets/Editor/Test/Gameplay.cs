using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

using ReduxExample.Gameplay;

namespace ReduxExample.Test{
	[TestFixture]
	public class Gameplay {
		Creator creator = new Creator();
		Store store = new Store();

		[SetUp]
		public void Init()
		{
			store.Init();
			creator.Init(store);
		}

		[Test]
		public void AttackEnemy()
		{	
			creator.Fight.Attack(AttackTarget.ENEMY, 10);
			Assert.That(store.Enemy.hp.Value == 90);
		}

		[Test]
		public void AttackPlayer()
		{
			creator.Fight.Attack(AttackTarget.PLAYER, 50);
			Assert.That(store.Player.hp.Value == 50);
		}
	}
}
