using System;
using UnityEngine;
using UnityEngine.Audio;

public class SettingView : MonoBehaviour
{
	public AudioMixer audioMixer;

	public CanvasGroup canvasGroup;

	public RectTransform main;

	public Action CloseAction;

	public GameObject buttonMusicEnabled;

	public GameObject buttonMusicDisabled;

	public GameObject buttonSoundEnabled;

	public GameObject buttonSoundDisabled;

	public GameObject buttonVibrateEnabled;

	public GameObject buttonVibrateDisabled;

	private RectTransformSnapPoint snapPointMain;

	private void Awake()
	{
	}

	private bool GetValue(string key)
	{
		return false;
	}

	private void SetValue(string key, bool value)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void ButtonSoundClicked()
	{
	}

	public void ButtonMusicClicked()
	{
	}

	public void ButtonVibrationClicked()
	{
	}

	public void ButtonPrivacyPolicyClicked()
	{
	}

	private void _003CClose_003Eb__15_0()
	{
	}
}
