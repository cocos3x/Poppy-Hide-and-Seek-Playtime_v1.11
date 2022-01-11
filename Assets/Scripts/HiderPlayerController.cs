using TPSShooter;
using UnityEngine;

public class HiderPlayerController : MonoBehaviour
{
	public Hider hider;

	public CharacterController characterController;

	public Joystick joystick;

	public float speedMultiplier;

	private Vector3 moveDirection;

	private float moveSpeed;

	private bool isMoving;

	private bool isPlaying;

	public void SetUp(Hider hider, CharacterController cc)
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
