using Firebase;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;

namespace Analytics
{
	public class TrackerController : MonoBehaviour
	{
		private static TrackerController _instance;

		public bool enableLog;

		private PropertyInfo[] propertyInfo;

		private List<string> parameterName;

		private List<string> parameterValue;

		private object stringCache;

		public bool firebaseIsReady;

		private string _null;

		public static TrackerController Instance => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void LogEvent(object eventType)
		{
		}

		public void LogEventML(string eventName)
		{
		}

		public void SetUserProperties(object eventType)
		{
		}

		private void _003CStart_003Eb__11_0(Task<DependencyStatus> task)
		{
		}
	}
}
