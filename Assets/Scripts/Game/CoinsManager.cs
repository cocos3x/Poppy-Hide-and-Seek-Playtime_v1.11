using Game.Config;
using Game.Core;
using Game.Core.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public sealed class CoinsManager : Mediator<LevelView>
	{
		private Timer _timer;

		private GameConfig _config;

		private GameManager _gameManager;

		private GameView _gameView;

		private readonly List<ParticleSystem> _effects;

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void TimerOnPOST_TICK()
		{
		}
	}
}
