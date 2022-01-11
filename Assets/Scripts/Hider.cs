using System;
using System.Collections.Generic;
using UnityEngine;

public class Hider : Character
{
	public enum State
	{
		Idle,
		Move,
		Caught,
		Win
	}

	public string id;

	public float rescueDistance;

	public bool canRescueOthers;

	public bool canBeRescued;

	public bool canBeCaught;

	public CageEffect cageEffect;

	public MovingEffect movingEffect;

	public ParticleSystem particleRewardRescue;

	public Animator animator;

	public Collider mainCollider;

	public SkinnedMeshRenderer[] skinnedMeshRenderers;

	public Action<Hider> OnGetCaught;

	public Action<Hider, Hider> OnGetReleased;

	public Action OnStartGame;

	public Action OnStopGame;

	private int layerInvisible;

	private int layerDefault;

	public bool isOnLand;

	private int layerMaskGround;

	private int fixedUpdateFrameCount;

	private int waterLayer;

	public State state;

	protected Seeker seeker;

	protected List<Hider> hiders;

	public GameObject[] seekerInvisibleObjects;

	private Transform cachedTransform;

	private void Awake()
	{
	}

	public void SetLayerAsPlayer()
	{
	}

	public void SetLayerAsAI()
	{
	}

	public virtual void StartGame()
	{
	}

	public virtual void StopGame()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetOnLand(bool flag)
	{
	}

	public void ToIdleState()
	{
	}

	public void ToMoveState()
	{
	}

	public void ToWinState()
	{
	}

	public virtual void GetCaught()
	{
	}

	public virtual void GetReleased(Hider subject)
	{
	}

	public void CheckRescueHiders()
	{
	}

	public void SetVisibleToSeeker(bool flag)
	{
	}

	public void SetAnimationSpeed(float speed)
	{
	}
}
