using System;

namespace Analytics
{
	public static class Tracker
	{
		public static bool IsReady => false;

		public static event Action OnFirebaseReady
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void LogEvent(object eventType)
		{
		}

		public static void SetUserProperties(object eventType)
		{
		}

		public static void LogEventML(ML_EVENT_TYPE eventName)
		{
		}

		internal static void NotifyFirebaseReadyEvent()
		{
		}
	}
}
