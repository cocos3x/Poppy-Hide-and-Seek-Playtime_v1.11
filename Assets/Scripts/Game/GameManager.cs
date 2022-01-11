using Game.Enemy;
using Game.Player;
using Injection;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public sealed class GameManager : IDisposable
	{
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public UnitView unitView;

			internal bool _003CKill_003Eb__0(EnemyController temp)
			{
				return false;
			}
		}

		public Action<UnitView> UNIT_KILLED;

		public Action<UnitView> UNIT_RESCUED;

		public Action<UnitView, int> COINS_COLLECTED;

		public Action<Vector3> UNIT_SOUND;

		private Injector _injector;

		private Context _context;

		private PlayerController _player;

		private readonly List<EnemyController> _enemies;

		public PlayerController Player => null;

		public int EnemiesCount => 0;

		public void Dispose()
		{
		}

		public void CreatePlayer(UnitView unit, bool isVictim)
		{
		}

		public void CreateEnemy(UnitView unit, bool isVictim)
		{
		}

		public void Kill(UnitView unitView)
		{
		}

		public void Rescue(UnitView unit)
		{
		}

		public void CollectCoin(UnitView unit, int value)
		{
		}

		public void FireSound(Vector3 position)
		{
		}
	}
}
