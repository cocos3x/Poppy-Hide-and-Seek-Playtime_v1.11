using System;
using UnityEngine;

public class LoseView : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__14_1;

		public static Action _003C_003E9__15_1;

		public static Action _003C_003E9__16_1;

		public static Action _003C_003E9__17_1;

		internal void _003CSkipButtonClicked_003Eb__14_1()
		{
		}

		internal void _003CSpeedUpButtonClicked_003Eb__15_1()
		{
		}

		internal void _003CIgnoreWallButtonClicked_003Eb__16_1()
		{
		}

		internal void _003CInvisibleButtonClicked_003Eb__17_1()
		{
		}
	}

	public Action OnReplay;

	public Action OnSkip;

	public Action OnNext;

	public Action OnSpeedUp;

	public Action OnIgnoreWall;

	public Action OnInvisible;

	public GameObject objectModeHide;

	public GameObject objectModeSeek;

	public GameObject skipButton;

	public GameObject nextButton;

	public GameObject[] boosterButtons;

	public void SetMode(GameMode gameMode, bool canNext)
	{
	}

	public void ReplayButtonClicked()
	{
	}

	public void NextButtonClicked()
	{
	}

	public void SkipButtonClicked()
	{
	}

	public void SpeedUpButtonClicked()
	{
	}

	public void IgnoreWallButtonClicked()
	{
	}

	public void InvisibleButtonClicked()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void _003CSkipButtonClicked_003Eb__14_0()
	{
	}

	private void _003CSpeedUpButtonClicked_003Eb__15_0()
	{
	}

	private void _003CIgnoreWallButtonClicked_003Eb__16_0()
	{
	}

	private void _003CInvisibleButtonClicked_003Eb__17_0()
	{
	}
}
