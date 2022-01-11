using System.Collections.Generic;
using TPSShooter;
using UnityEngine;

public class SeekerPlayerControler : MonoBehaviour
{
	public Seeker seeker;

	public CharacterController characterController;

	public Joystick joystick;

	public float speedMultiplier;

	private Vector3 moveDirection;

	private float moveSpeed;

	private bool isMoving;

	private bool isPlaying;

	private List<Hider> hiders;

	public void Setup(Seeker seeker, CharacterController cc)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnStartGame()
	{
	}

	public void OnStopGame()
	{
	}

	public void Update()
	{
	}

	public void SetSpeedMultiplier(float value)
	{
	}
}
