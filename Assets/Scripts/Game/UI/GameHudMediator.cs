using Game.Config;
using Game.Core;
using Game.Core.UI;

namespace Game.UI
{
	public sealed class GameHudMediator : Mediator<GameHud>
	{
		private GameConfig _config;

		private Timer _timer;

		private LevelView _levelView;

		private GameModel _gameModel;

		private GameManager _gameManager;

		private readonly bool _isHided;

		private float _startTime;

		public GameHudMediator(bool isHided)
		{
		}

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void OnHideTimeCompleted()
		{
		}

		private void TimerOnPOST_TICK()
		{
		}

		private void OnCoinsCollected(UnitView unit, int value)
		{
		}

		private float _003CShow_003Eb__8_0()
		{
			return 0f;
		}

		private void _003CShow_003Eb__8_1(float x)
		{
		}
	}
}
