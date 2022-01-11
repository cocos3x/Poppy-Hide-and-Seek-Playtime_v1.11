using UnityEngine;

public class RadarController : MonoBehaviour
{
	public Transform target;

	public Vector3 offset;

	public MeshFilter meshFilter;

	public float radius;

	public float offsetAngle;

	public float fov;

	public int resolution;

	private int blockLayermask;

	private float deltaAngle;

	private Mesh mesh;

	private Vector3[] vertices;

	private Vector2[] texCoords;

	private int[] indices;

	private int frameCount;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
