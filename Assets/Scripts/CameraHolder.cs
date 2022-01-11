using UnityEngine;

public class CameraHolder : MonoBehaviour
{
	public Transform Holder;

	public float currDistance;

	public float xRotate;

	public float yRotate;

	public float yMinLimit;

	public float yMaxLimit;

	public float prevDistance;

	private float x;

	private float y;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
