using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Reporter : MonoBehaviour
{
	public enum _LogType
	{
		Assert = 1,
		Error = 0,
		Exception = 4,
		Log = 3,
		Warning = 2
	}

	public class Sample
	{
		public float time;

		public byte loadedScene;

		public float memory;

		public float fps;

		public string fpsText;

		public static float MemSize()
		{
			return 0f;
		}

		public string GetSceneName()
		{
			return "";
		}
	}

	public class Log
	{
		public int count;

		public _LogType logType;

		public string condition;

		public string stacktrace;

		public int sampleId;

		public Log CreateCopy()
		{
			return null;
		}

		public float GetMemoryUsage()
		{
			return 0f;
		}
	}

	private enum ReportView
	{
		None,
		Logs,
		Info,
		Snapshot
	}

	private enum DetailView
	{
		None,
		StackTrace,
		Graph
	}


	private List<Sample> samples;

	private List<Log> logs;

	private List<Log> collapsedLogs;

	private List<Log> currentLog;

	private MultiKeyDictionary<string, string, Log> logsDic;

	private Dictionary<string, string> cachedString;

	public bool show;

	private bool collapse;

	private bool clearOnNewSceneLoaded;

	private bool showTime;

	private bool showScene;

	private bool showMemory;

	private bool showFps;

	private bool showGraph;

	private bool showLog;

	private bool showWarning;

	private bool showError;

	private int numOfLogs;

	private int numOfLogsWarning;

	private int numOfLogsError;

	private int numOfCollapsedLogs;

	private int numOfCollapsedLogsWarning;

	private int numOfCollapsedLogsError;

	private bool showClearOnNewSceneLoadedButton;

	private bool showTimeButton;

	private bool showSceneButton;

	private bool showMemButton;

	private bool showFpsButton;

	private bool showSearchText;

	private bool showCopyButton;

	private bool showSaveButton;

	private string buildDate;

	private string logDate;

	private float logsMemUsage;

	private float graphMemUsage;

	private float gcTotalMemory;

	public string UserData;

	public float fps;

	public string fpsText;

	private ReportView currentView;

	private static bool created;

	public Images images;

	private GUIContent clearContent;

	private GUIContent collapseContent;

	private GUIContent clearOnNewSceneContent;

	private GUIContent showTimeContent;

	private GUIContent showSceneContent;

	private GUIContent userContent;

	private GUIContent showMemoryContent;

	private GUIContent softwareContent;

	private GUIContent dateContent;

	private GUIContent showFpsContent;

	private GUIContent infoContent;

	private GUIContent saveLogsContent;

	private GUIContent searchContent;

	private GUIContent copyContent;

	private GUIContent closeContent;

	private GUIContent buildFromContent;

	private GUIContent systemInfoContent;

	private GUIContent graphicsInfoContent;

	private GUIContent backContent;

	private GUIContent logContent;

	private GUIContent warningContent;

	private GUIContent errorContent;

	private GUIStyle barStyle;

	private GUIStyle buttonActiveStyle;

	private GUIStyle nonStyle;

	private GUIStyle lowerLeftFontStyle;

	private GUIStyle backStyle;

	private GUIStyle evenLogStyle;

	private GUIStyle oddLogStyle;

	private GUIStyle logButtonStyle;

	private GUIStyle selectedLogStyle;

	private GUIStyle selectedLogFontStyle;

	private GUIStyle stackLabelStyle;

	private GUIStyle scrollerStyle;

	private GUIStyle searchStyle;

	private GUIStyle sliderBackStyle;

	private GUIStyle sliderThumbStyle;

	private GUISkin toolbarScrollerSkin;

	private GUISkin logScrollerSkin;

	private GUISkin graphScrollerSkin;

	public Vector2 size;

	public float maxSize;

	public int numOfCircleToShow;

	private static string[] scenes;

	private string currentScene;

	private string filterText;

	private string deviceModel;

	private string deviceType;

	private string deviceName;

	private string graphicsMemorySize;

	private string maxTextureSize;

	private string systemMemorySize;

	public bool Initialized;

	private Rect screenRect;

	private Rect toolBarRect;

	private Rect logsRect;

	private Rect stackRect;

	private Rect graphRect;

	private Rect graphMinRect;

	private Rect graphMaxRect;

	private Rect buttomRect;

	private Vector2 stackRectTopLeft;

	private Rect detailRect;

	private Vector2 scrollPosition;

	private Vector2 scrollPosition2;

	private Vector2 toolbarScrollPosition;

	private Log selectedLog;

	private float toolbarOldDrag;

	private float oldDrag;

	private float oldDrag2;

	private float oldDrag3;

	private int startIndex;

	private Rect countRect;

	private Rect timeRect;

	private Rect timeLabelRect;

	private Rect sceneRect;

	private Rect sceneLabelRect;

	private Rect memoryRect;

	private Rect memoryLabelRect;

	private Rect fpsRect;

	private Rect fpsLabelRect;

	private GUIContent tempContent;

	private Vector2 infoScrollPosition;

	private Vector2 oldInfoDrag;

	private Rect tempRect;

	private float graphSize;

	private int startFrame;

	private int currentFrame;

	private Vector3 tempVector1;

	private Vector3 tempVector2;

	private Vector2 graphScrollerPos;

	private float maxFpsValue;

	private float minFpsValue;

	private float maxMemoryValue;

	private float minMemoryValue;

	private List<Vector2> gestureDetector;

	private Vector2 gestureSum;

	private float gestureLength;

	private int gestureCount;

	private float lastClickTime;

	private Vector2 startPos;

	private Vector2 downPos;

	private Vector2 mousePosition;

	private int frames;

	private bool firstTime;

	private float lastUpdate;

	private const int requiredFrames = 10;

	private const float updateInterval = 0.25f;

	private List<Log> threadedLogs;

	public float TotalMemUsage => 0f;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void addSample()
	{
	}

	public void Initialize()
	{
	}

	private void initializeStyle()
	{
	}

	private void Start()
	{
	}

	private void clear()
	{
	}

	private void calculateCurrentLog()
	{
	}

	private void DrawInfo()
	{
	}

	private void drawInfo_enableDisableToolBarButtons()
	{
	}

	private void DrawReport()
	{
	}

	private void drawToolBar()
	{
	}

	private void DrawLogs()
	{
	}

	private void drawGraph()
	{
	}

	private void drawStack()
	{
	}

	public void OnGUIDraw()
	{
	}

	private bool isGestureDone()
	{
		return false;
	}

	private bool isDoubleClickDone()
	{
		return false;
	}



	private void calculateStartIndex()
	{
	}

	private void doShow()
	{
	}

	private void Update()
	{
	}

	private void CaptureLog(string condition, string stacktrace, LogType type)
	{
	}

	private void AddLog(string condition, string stacktrace, LogType type)
	{
	}

	private void CaptureLogThread(string condition, string stacktrace, LogType type)
	{
	}

	private void _OnLevelWasLoaded(Scene _null1, LoadSceneMode _null2)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private IEnumerator readInfo()
	{
		return null;
	}

	private void SaveLogsToDevice()
	{
	}
}
