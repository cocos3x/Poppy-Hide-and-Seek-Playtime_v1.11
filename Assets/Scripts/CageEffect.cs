using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CageEffect : MonoBehaviour
{

	public GameObject cageMeshObject;

	public ParticleSystem particleSmoke;

	public ParticleSystem particleText;

	public ParticleSystem particleRecure;

	public AudioSource audioSourceCaught;

	public AudioSource audioSourceRescued;

	private Coroutine particleTextPlayCoroutine;

	public void Play()
	{
	}

	public void Stop()
	{
	}

	private IEnumerator PlayParticleDelay(ParticleSystem particle, float delay)
	{
		return null;
	}
}
