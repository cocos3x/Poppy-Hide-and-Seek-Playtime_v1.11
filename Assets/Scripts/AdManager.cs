using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class AdManager : SingletonMonoBehaviour<AdManager>
{

	private bool doneAdsInterval;

	private static Action rewardedAdSucceededEvent;

	private static Action interstitialAdClosedEvent;

	private static Action interstitialAdSucceededEvent;

	private static Action interstitialAdFailedEvent;

	private const string MaxSdkKey = "bmTTF_USp-Li1RtblN5tUGHwLh83crRSVPQ0bTT88LSlzTcX_J_lMrHcwXZ3L08PndktTp7gRFWXLpU2aJF5yn";

	private const string InterstitialAdUnitId = "9e63324a97b57ceb";

	private const string RewardedAdUnitId = "b1d613cf0e3951be";

	private const string BannerAdUnitId = "bdc4b7b07b54b99d";

	private bool isBannerShowing;

	private int interstitialRetryAttempt;

	private int rewardedRetryAttempt;

	private int rewardedInterstitialRetryAttempt;

	public Action AudioPauseAction;

	public Action AudioResumeAction;

	public override void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetAdsInterval()
	{
	}

	private IEnumerator WaitAdsStartDelay()
	{
		return null;
	}

	private IEnumerator WaitEndAdsInterval()
	{
		return null;
	}

	private void InitializeInterstitialAds()
	{
	}

	private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void ImpressionSuccessEvent(MaxSdkBase.AdInfo adInfo)
	{
	}

	private void LoadInterstitial()
	{
	}

	public void ShowInterstitialAd(Action ClosedEvent, Action SucceededEvent, Action FailedEvent)
	{
	}

	private void OnInterstitialDisplayedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialClickedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void InitializeRewardedAds()
	{
	}

	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void LoadRewardedAd()
	{
	}

	public void ShowRewardedAd(Action succeededEvent, Action failedEvent)
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private IEnumerator WaitRewarded()
	{
		return null;
	}

	private void InitializeBannerAds()
	{
	}

	private void DelayInitBanner()
	{
	}

	private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}

	private void ToggleBannerVisibility()
	{
	}

	private void _003CStart_003Eb__16_0(MaxSdkBase.SdkConfiguration sdkConfiguration)
	{
	}
}
