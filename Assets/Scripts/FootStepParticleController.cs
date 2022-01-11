using UnityEngine;

public class FootStepParticleController : MonoBehaviour
{
	public delegate bool PredicateVoid();

	public Hider hider;

	public PredicateVoid CheckOnGround;

	public static float spawnFootStepDistanceThreshold;

	public ParticleSystem particleSystemFootStep;

	public ParticleSystem particleSystemFootSplat;

	private Vector3 previousPosition;

	private float stickDuration;

	private float fadeDuration;

	private Color color;

	private float time;

	private float totalDuration;

	private bool canSpawn;

	public void Show(Color color, float stickDuration, float fadeDuration)
	{
	}

	public void Update()
	{
	}

	private void Hide()
	{
	}

	public void StopSpawning()
	{
	}
}
