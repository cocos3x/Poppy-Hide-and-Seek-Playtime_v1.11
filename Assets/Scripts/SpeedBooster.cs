using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class SpeedBooster : SingletonMonoBehaviour<SpeedBooster>
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public float speedMultiplier;

		public SeekerPlayerControler seekerPlayerControler;

		public SpeedBoostEffect effect;

		internal float _003CBoostSpeed_003Eb__0()
		{
			return 0f;
		}

		internal void _003CBoostSpeed_003Eb__1(float value)
		{
		}

		internal void _003CBoostSpeed_003Eb__2()
		{
		}
	}


	public float duration;

	public float boostValue;

	private Tween tweenSlowdown;

	public void Stop()
	{
	}

	public void SetTarget(SeekerPlayerControler seekerPlayerControler)
	{
	}

	public void SetTarget(HiderPlayerController hiderPlayerController)
	{
	}

	private IEnumerator BoostSpeed(SeekerPlayerControler seekerPlayerControler, float second)
	{
		return null;
	}

	private IEnumerator BoostSpeed(HiderPlayerController hiderPlayerController, float second)
	{
		return null;
	}
}
