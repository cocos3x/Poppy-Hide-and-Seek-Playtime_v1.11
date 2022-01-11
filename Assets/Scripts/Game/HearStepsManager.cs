using Game.Core;
using Game.Core.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public sealed class HearStepsManager : Mediator<LevelView>
	{
		private Timer _timer;

		private GameView _gameView;

		private GameManager _gameManager;

		private LevelView _levelView;

		private readonly bool _isShowEffects;

		private readonly List<ParticleSystem> _effects;

		private AnimationType[] _animations;

		public HearStepsManager(bool isShowEffects)
		{
		}

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void TimerOnPostTick()
		{
		}

		private void CreateEffect(UnitView unit)
		{
		}

		private void OnCollisionDetected(Collider collider)
		{
		}
	}
}
