using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class IgnoreWall : SingletonMonoBehaviour<IgnoreWall>
{
	
	public float duration;

	public Material material;

	public void ApplyToTarget(Hider hider)
	{
	}

	public void Stop()
	{
	}

	private IEnumerator MakeHiderInvisibleForSeconds(Hider hider, float duration)
	{
		return null;
	}

	public void ApplyToTarget(Seeker seeker)
	{
	}

	private IEnumerator MakeHiderInvisibleForSeconds(Seeker seeker, float duration)
	{
		return null;
	}
}
