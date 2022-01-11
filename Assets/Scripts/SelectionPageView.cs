using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class SelectionPageView : MonoBehaviour
{

	public Sprite spriteUnlocked;

	public Sprite spriteLocked;

	public RectTransform selectedImage;

	public Image[] selectionButtonImages;

	public Action<bool, string> OnSelectId;

	[NonSerialized]
	public string currentId;

	public bool isFullUnlocked;

	public IEnumerator UnlockRandom(AnimationCurve unlockRandomTimeCurve, Action OnComplete)
	{
		return null;
	}

	private void Unlock(Image selectionImage, bool unlocked)
	{
	}

	public void UpdateSelectButtons()
	{
	}

	private bool IsUnlocked(string id)
	{
		return false;
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void SelectId(int idx)
	{
	}
}
