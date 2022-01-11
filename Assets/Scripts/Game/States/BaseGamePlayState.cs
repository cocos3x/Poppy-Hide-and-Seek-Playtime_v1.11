using Game.Config;
using Game.Core;
using Game.Core.UI;
using Injection;
using System.Collections.Generic;
using UnityEngine;

namespace Game.States
{
	public abstract class BaseGamePlayState : GameState
	{
		protected GameManager _gameManager;

		protected LevelView _levelView;

		protected GameView _gameView;

		protected Timer _timer;

		protected GameStateManager _gameStateManager;

		protected GameModel _gameModel;

		protected Injector _injector;

		protected GameConfig _config;

		private readonly List<Mediator> _mediators;

		protected float _startTime;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		protected void AddMediator<T>(Mediator<T> mediator, T hud) where T : MonoBehaviour
		{
		}
	}
}
