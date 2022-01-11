using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
	public Transform target;

	public Vector3 offset;

	public Transform audioListenerTransform;

	private Transform cachedTransform;

	private void Awake()
	{
	}

	public void SetTarget(Transform target, Vector3 offset)
	{
	}

	private void LateUpdate()
	{
	}
}
