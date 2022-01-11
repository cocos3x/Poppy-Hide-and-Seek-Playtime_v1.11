using Game.Core;
using Game.Core.UI;
using UnityEngine;

namespace Game.UI
{
	public sealed class RadarHudMediator : Mediator<GameHud>
	{
		private Timer _timer;

		private LevelView _levelView;

		private float _minX;

		private float _maxX;

		private float _minY;

		private float _maxY;

		private UnityEngine.Camera _camera;

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void TimerOnPOST_TICK()
		{
		}

		private bool IsBetweenInclusive(float value, float bound1, float bound2)
		{
			return false;
		}
	}
}
