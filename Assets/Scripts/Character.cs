using System;
using UnityEngine;

public class Character : MonoBehaviour
{
	public bool isPlayer;

	protected bool isPlaying;

	public Rigidbody rigidbody;

	public Action<Vector3> OnTeleport;

	public void Teleport(Vector3 position)
	{
	}
}
