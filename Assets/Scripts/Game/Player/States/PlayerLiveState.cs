using Game.Config;
using Game.Core;
using TPSShooter;
using UnityEngine;

namespace Game.Player.States
{
	public sealed class PlayerLiveState : PlayerState
	{
		private Timer _timer;

		private GameView _view;

		private PlayerController _playerController;

		private GameConfig _config;

		private GameManager _gameManager;

		private Joystick _joystick;

		private Transform _transform;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void TimerOnTICK()
		{
		}
	}
}
