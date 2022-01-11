using System;
using System.Collections.Generic;

[Serializable]
public class UserData
{
	public static UserData current;

	public DateTime activeTime;

	public int activeCount;

	public string name;

	public int level;

	public int coin;

	public int dayActive;

	public int session;

	public int fullAdsCount;

	public int rewardAdsCount;

	public bool removedAds;

	public bool rated;

	public string lastActiveTime;

	public string currentHiderId;

	public string currentSeekerId;

	public List<string> unlockCharacterIds;

	public List<RewardedAdCounter> rewardedAdCounters;

	public TempData tempData;

	[NonSerialized]
	public bool isDifferentDayFromLastSession;

	private static bool isLoaded;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public string EncryptData(string data, string key)
	{
		return "";
	}

	public string DecryptData(string data, string key)
	{
		return "";
	}

	public static void Save()
	{
	}

	public static bool Load(bool forceReload = false)
	{
		return false;
	}
}
