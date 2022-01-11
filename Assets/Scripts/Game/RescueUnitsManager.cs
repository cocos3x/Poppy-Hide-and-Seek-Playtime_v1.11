using Game.Config;
using Game.Core;
using Game.Core.UI;

namespace Game
{
	public sealed class RescueUnitsManager : Mediator<LevelView>
	{
		private Timer _timer;

		private GameManager _gameManager;

		private GameConfig _config;

		private float[] _lastRescueTime;

		private int _victimLayerMask;

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
