using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Shining : MonoBehaviour
{

	[SerializeField]
	private float width;

	[SerializeField]
	private float shiningTime;

	private Image image;

	private SpriteRenderer sprite;

	private WaitForSeconds waitForSeconds;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator Shine()
	{
		return null;
	}

	private IEnumerator Shine2()
	{
		return null;
	}
}
