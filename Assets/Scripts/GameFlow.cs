using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class GameFlow : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public float colorTweenTime;

		public Color colorStartBackground;

		public Color colorEndBackGround;

		public Color colorStartFog;

		public Color colorEndFog;

		public GameFlow _003C_003E4__this;

		internal float _003CLoadLevel_003Eb__0()
		{
			return 0f;
		}

		internal void _003CLoadLevel_003Eb__1(float value)
		{
		}

		internal void _003CLoadLevel_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public CameraFollowPlayer cameraFollowPlayer;

		internal void _003COnGameStart_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_1
	{
		public Transform cameraTransform;

		public Character playerCharacter;

		public CameraFollowPlayer cameraFollowPlayer;

		public GameFlow _003C_003E4__this;

		public TweenCallback _003C_003E9__3;

		internal void _003COnGameStart_003Eb__2()
		{
		}

		internal void _003COnGameStart_003Eb__3()
		{
		}
	}


	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__71_1;

		public static Action _003C_003E9__71_2;

		public static Action _003C_003E9__72_2;

		public static Action _003C_003E9__72_3;

		public static Action _003C_003E9__76_1;

		internal void _003COnReplay_003Eb__71_1()
		{
		}

		internal void _003COnReplay_003Eb__71_2()
		{
		}

		internal void _003COnNext_003Eb__72_2()
		{
		}

		internal void _003COnNext_003Eb__72_3()
		{
		}

		internal void _003COnPlayWithBooster_003Eb__76_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public int type;

		public GameFlow _003C_003E4__this;

		internal void _003COnPlayWithBooster_003Eb__0()
		{
		}
	}

	public LevelController[] levelPrefabs;

	public AudioMixer audioMixer;

	public Camera gameCamera;

	public AudioSource audioSourceWin;

	public AudioSource audioSourceLose;

	public RadarVisualizer radarForward;

	public Transform[] envBlocks;

	public LoadingView loadingView;

	public TextMeshCountdown textMeshCountdown;

	public GameObject blocker;

	public StartView startView;

	public PlayView playView;

	public WinView winView;

	public LoseView loseView;

	public RateView rateView;

	public TutorialView tutorialView;

	public ShopView shopView;

	public Material materialHiddenWall;

	public Material materialOutline;

	public Material materialBackground;

	public float cameraStartDistance;

	public float cameraStartAngle;

	public float cameraPlayDistance;

	public float cameraPlayAngle;

	public float cameraStartDistancceSeek;

	private GameMode mode;

	private float time;

	private float duration;

	private bool isPlaying;

	private bool isCountdownPlayingTime;

	private int caughtHiderCount;

	private int rescuedHiderCount;

	private int collectedCoin;

	private bool gameEnd;

	private int minCaughtHiderCount;

	private int rewardPerRescue;

	private int rewardPerCatch;

	private NavMeshDataInstance currentNavMeshDataInstance;

	private LevelController levelInstance;

	private LevelController levelInstancePrevious;

	private bool levelExist;

	private CharacterManager characterManager;

	public bool useSpeedBoost;

	public bool useInvisibility;

	public bool useIgnoreWall;

	private bool isReplay;

	private Vector3 levelPosition;

	private bool isFirstLoaded;

	private int loadNewMapTimeCount;

	private int loseThisLevelTimeCount;

	public void LoadLevel()
	{
	}

	private void CameraDOTransformation(Transform cameraTransform, Vector3 position, Quaternion rotation, float duration, TweenCallback OnCompleted)
	{
	}

	public void ClearLevel()
	{
	}

	private void SetupAdManagerForIOS()
	{
	}

	public void Start()
	{
	}

	private void OnFirebaseReady()
	{
	}

	public void OnDestroy()
	{
	}

	private void SetTransform(Character character, Vector3 position)
	{
	}

	private void OnCoinCollected(Character character, CoinController coin)
	{
	}

	private void OnHiderGetCaught(Hider hider)
	{
	}

	private void OnHiderGetReleased(Hider subject, Hider hider)
	{
	}

	private void OnGameStart()
	{
	}

	public void OnGameEnd()
	{
	}

	private IEnumerator Countdown(Action OnCompleted)
	{
		return null;
	}

	private IEnumerator StartCharacterDelay(float delay)
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnTimeOut()
	{
	}

	public void OnAllHidersCaught()
	{
	}

	public void OnHiderPlayerCaught()
	{
	}

	private IEnumerator OpenWinViewDelay(float delay)
	{
		return null;
	}

	private void OnReplayLevelWithBooster()
	{
	}

	private void OnReplay()
	{
	}

	private void OnNext()
	{
	}

	private void OnSkip()
	{
	}

	public void OnPlayModeHide()
	{
	}

	public void OnPlayModeSeek()
	{
	}

	public void OnPlayWithBooster(int type)
	{
	}

	private bool IsLevelRate()
	{
		return false;
	}

	private void SetAdjustEvent(int level)
	{
	}

	private void _003CLoadLevel_003Eb__50_3()
	{
	}

	private void _003CSetupAdManagerForIOS_003Eb__53_0()
	{
	}

	private void _003CSetupAdManagerForIOS_003Eb__53_1()
	{
	}

	private void _003CStart_003Eb__54_0()
	{
	}

	private void _003CStart_003Eb__54_1()
	{
	}

	private void _003CStart_003Eb__54_2()
	{
	}

	private void _003CStart_003Eb__54_3()
	{
	}

	private void _003CStart_003Eb__54_4()
	{
	}

	private void _003COnGameStart_003Eb__61_1()
	{
	}

	private void _003COnReplay_003Eb__71_0()
	{
	}

	private void _003COnNext_003Eb__72_0()
	{
	}

	private void _003COnNext_003Eb__72_1()
	{
	}
}
