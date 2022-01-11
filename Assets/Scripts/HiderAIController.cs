using UnityEngine;
using UnityEngine.AI;

public class HiderAIController : MonoBehaviour
{
	public Hider hider;

	public NavMeshAgent navMeshAgent;

	private float idleTime;

	private float agentSpeed;

	private int hidePositionIndex;

	private bool isPlaying;

	public void Setup(Hider hider, NavMeshAgent mna)
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

	public void OnGetCaught(Hider hider)
	{
	}

	public void OnGetReleased(Hider subject, Hider hider)
	{
	}

	private void Update()
	{
	}

	private void ToIdleState()
	{
	}

	private void Hide()
	{
	}

	private bool IsNavMeshAgentReachDestination()
	{
		return false;
	}
}
