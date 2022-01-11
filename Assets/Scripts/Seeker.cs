using System;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : Character
{
	public enum State
	{
		Start,
		Seek,
		Look,
		Hear,
		Win,
		Lose
	}

	public string id;

	public float hearDistance;

	public float catchDistance;

	public Animator animator;

	public SkinnedMeshRenderer skinnedMeshRenderer;

	public Collider mainCollider;

	public ParticleSystem particleRewardCatch;

	private float catchDistanceSqr;

	public State state;

	[NonSerialized]
	public List<Hider> hiders;

	private static int wallBitmask;

	public Action OnStartGame;

	public Action OnStopGame;

	private Transform cachedTransform;

	public bool isOnLand;

	private int layerMaskGround;

	private int fixedUpdateFrameCount;

	private int waterLayer;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetOnLand(bool flag)
	{
	}

	public void SetLayerAsPlayer()
	{
	}

	public void SetLayerAsAI()
	{
	}

	public void CheckCatchHiders()
	{
	}

	public bool CanHear(Hider hider)
	{
		return false;
	}

	public bool CanCatch(Hider hider)
	{
		return false;
	}

	public void StartGame()
	{
	}

	public void StopGame()
	{
	}

	public void ToLookState()
	{
	}

	public void ToSeekState()
	{
	}

	public void ToHearState()
	{
	}

	public void ToWinState()
	{
	}

	public void ToLoseState()
	{
	}

	public void ToStartState()
	{
	}

	public void SetAnimationSpeed(float speed)
	{
	}
}
