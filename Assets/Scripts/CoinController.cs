using System;
using UnityEngine;

public class CoinController : MonoBehaviour
{
	public int value;

	public Collider collider;

	public Transform pivot;

	public AudioSource audioSourceCollected;

	public ParticleSystem particleNormal;

	public ParticleSystem particleCollected;

	public static event Action<Character, CoinController> CoinCollectedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollected(Character character)
	{
	}
}
