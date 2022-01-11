using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class RemoteConfigControl : SingletonMonoBehaviour<RemoteConfigControl>
{
	public Action OnFetchDone;

	public bool isDataFetched;

	public static int interstitialAds_Interval;

	public static int interstitialAds_MinLevel;

	public static string levelRateData;

	public static float taichi_Threshold;

	public static List<int> rateLevels;

	public void InitializeFirebase()
	{
	}

	public void FetchDataAsync()
	{
	}

	private void FetchComplete(Task fetchTask)
	{
	}

	private void RefrectProperties()
	{
	}

	private void SaveData()
	{
	}

	public void LoadCachedData()
	{
	}

	private static void ParseRateLevelData()
	{
	}
}
