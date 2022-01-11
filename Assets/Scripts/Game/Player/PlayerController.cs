using Game.Config;
using Game.Core;
using Game.Player.States;
using Injection;
using System;
using UnityEngine;

namespace Game.Player
{
	public sealed class PlayerController : IDisposable
	{
		private GameConfig _config;

		private readonly UnitView _view;

		private readonly StateManager<PlayerState> _playerStateManager;

		public UnitView View => null;

	
		public bool IsDied => false;

		public PlayerController(Context context, UnitView player)
		{
		}

		public void Dispose()
		{
		}

		public void Live(bool isVictim)
		{
		}

		public void Kill()
		{
		}

		public Collider RaycastVictim()
		{
			return null;
		}
	}
}
