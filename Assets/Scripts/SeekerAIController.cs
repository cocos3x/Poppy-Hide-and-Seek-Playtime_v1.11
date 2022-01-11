using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekerAIController : MonoBehaviour
{
	public Seeker seeker;

	public NavMeshAgent navMeshAgent;

	private float lookTime;

	private float lookRotateSpeed;

	private float hearTime;

	private float hearRotateSpeed;

	private Vector3 hearPosition;

	private bool isSeekingHearTarget;

	private Hider hearTarget;

	public Transform seekTarget;

	private int hidePositionIndex;

	private bool isPlaying;

	private List<Hider> hiders;

	public void Setup(Seeker seeker, NavMeshAgent agent)
	{
	}

	private void Start()
	{
	}

	public void OnStartGame()
	{
	}

	public void OnStopGame()
	{
	}

	private void Update()
	{
	}

	private bool IsNavMeshAgentReachDestination()
	{
		return false;
	}

	private void ToLookState()
	{
	}

	private void ToHearState()
	{
	}

	private void Seek()
	{
	}

	private void Seek(Vector3 position)
	{
	}
}
