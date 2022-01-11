using Game.Config;
using Game.Core;
using Game.Enemy.States;
using Injection;
using System;
using UnityEngine;

namespace Game.Enemy
{
	public sealed class EnemyController : IDisposable
	{
		private GameConfig _config;

		private readonly UnitView _view;

		private readonly StateManager<EnemyState> _enemyStateManager;

		private Vector2 _003CLastHearVictim_003Ek__BackingField;

		public UnitView View => null;

		

		public float Speed => 0f;

		public float RotationSpeed => 0f;

		
		public EnemyController(UnitView view, Context context)
		{
		}

		public void Dispose()
		{
		}

		public void Kill()
		{
		}

		public void Live(bool isVictim)
		{
		}

		public Collider GetSeenVictim()
		{
			return null;
		}
	}
}
