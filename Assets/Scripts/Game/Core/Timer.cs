using System;

namespace Game.Core
{
	public sealed class Timer
	{
		private readonly OneListener _tickListener;

		private readonly OneListener _postTickListener;

		private readonly OneListener _oneSecondTickListener;

		private float _unscaledTime;

		private float _lastTime;

		private float _deltaTime;

		private float _scaleTime;

		private float _time;

		public static float time => 0f;

		public float Time => 0f;

		public float DeltaTime => 0f;

		public float TimeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UnscaladeTime => 0f;

		public event Action TICK
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action POST_TICK
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action ONE_SECOND_TICK
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Update()
		{
		}

		public void LateUpdate()
		{
		}

		private float GetTime()
		{
			return 0f;
		}
	}
}
