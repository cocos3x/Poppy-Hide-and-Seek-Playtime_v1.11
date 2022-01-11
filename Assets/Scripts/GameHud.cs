using TMPro;
using TPSShooter;
using UnityEngine;
using UnityEngine.UI;

public sealed class GameHud : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _txtTimeToHide;

	[SerializeField]
	private TextMeshProUGUI _txtTimeToHideLabel;

	[SerializeField]
	private TimeCounterColors _colors;

	[SerializeField]
	private TextMeshProUGUI _txtTimeLeft;

	[SerializeField]
	private Image _imgTimeLeft;

	[SerializeField]
	private TextMeshProUGUI _txtCoins;

	[SerializeField]
	public Joystick Joystick;

	[SerializeField]
	public RectTransform TrRadarIcon;

	private int _roundedTime;

	private int _coins;

	private float _time;

	public string TimeToHideLabelText
	{
		set
		{
		}
	}

	public int Coins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float TimeToHide
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool SetTimeLeft(float startTime, float duration, bool isGreenTimeRemain)
	{
		return false;
	}
}
