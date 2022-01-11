using System.Threading;
using UnityEngine;

public class TestReporter : MonoBehaviour
{
	public int logTestCount;

	public int threadLogTestCount;

	public bool logEverySecond;

	private int currentLogTestCount;

	private Reporter reporter;

	private GUIStyle style;

	private Rect rect1;

	private Rect rect2;

	private Rect rect3;

	private Rect rect4;

	private Rect rect5;

	private Rect rect6;

	private Thread thread;

	private float elapsed;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void threadLogTest()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}
}
