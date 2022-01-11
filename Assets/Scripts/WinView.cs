using DG.Tweening;
using System;
using TMPro;
using UnityEngine;

public class WinView : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__21_1;

		internal void _003COnSpineClicked_003Eb__21_1()
		{
		}
	}

	public Action OnReplay;

	public Action OnNext;

	public TextMeshProUGUI textTotalReward;

	public TextMeshProUGUI textRescue;

	public TextMeshProUGUI textRescueReward;

	public TextMeshProUGUI textCollectedReward;

	public TextMeshProUGUI textMultiply;

	public RectTransform rectTransformNeedle;

	public AnimationCurve animCurveNeedle;

	public GameObject spinObject;

	private Tween tweenNeedleRotate;

	private int spinMutiply;

	private int prevSpinMutiply;

	private int totalReward;

	public void ReplayButtonClicked()
	{
	}

	public void NextButtonClicked()
	{
	}

	public void SetRewardHideMode(int rescueCount, int rewardPerRescue, int collected, int total)
	{
	}

	public void SetRewardSeekMode(int catchCount, int rewardPerCatch, int collected, int total)
	{
	}

	public void Update()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnSpineClicked()
	{
	}

	private void _003COnSpineClicked_003Eb__21_0()
	{
	}
}
