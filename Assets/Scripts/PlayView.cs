using System;
using TMPro;
using TPSShooter;
using UnityEngine;
using UnityEngine.UI;

public class PlayView : MonoBehaviour
{
	public AudioSource audioSource10s;

	public RectTransform rectTransformSeekerPointer;

	public RectTransform rectTransformSeekerHear;

	public Camera cameraGameplay;

	public TextMeshProUGUI textTime;

	public TextMeshProUGUI textCountdown;

	public GameObject topObject;

	public Image imageTimeProgress;

	public Joystick joystick;

	public Image[] imagesCount;

	[NonSerialized]
	public Seeker seeker;

	private bool seekerVisiblePrevious;

	private Vector2 canvasSize;

	private float aspectRatio;

	private bool isSeekerHearing;

	private float duration;

	private bool isPlaying;

	private GameMode currentMode;

	private int timeInSecond;

	private Color colorCountDefault;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnGameStart(GameMode mode, float dur)
	{
	}

	public void OnGameEnd()
	{
	}

	public void SetMinCaught(int count)
	{
	}

	public void SetCount(int count, bool flag)
	{
	}

	public void SetTime(float time)
	{
	}

	public void OnStartCountdown()
	{
	}

	public void SetCoutdownTime(int second, bool anim = true)
	{
	}

	public void OnFinishCountdown()
	{
	}

	public void Update()
	{
	}

	private void UpdateSeekerPointer()
	{
	}

	private void UpdateSeekerHearingMark()
	{
	}
}
