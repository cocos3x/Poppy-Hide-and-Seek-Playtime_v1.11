using UnityEngine;

public class ItemBooster : MonoBehaviour
{
	public enum Type
	{
		Invisible,
		SpeedUp,
		IgnoreWall
	}

	public Type type;

	public ParticleSystem particleSystemOnPick;

	public Collider collider;

	public GameObject visual;

	public void OnTriggerEnter(Collider other)
	{
	}
}
