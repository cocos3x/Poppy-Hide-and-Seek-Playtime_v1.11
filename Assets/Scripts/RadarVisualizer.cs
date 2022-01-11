using UnityEngine;

public class RadarVisualizer : MonoBehaviour
{
	public Vector3 offset;

	public Camera depthRenderCamera;

	public RenderTexture depthTexture;

	public int textureWith;

	public int textureHeight;

	public float fov;

	public Shader depthReplacementShader;

	public Material materialView;

	public Renderer renderer1;

	public Renderer renderer2;

	private static int shaderId_CamPos;

	private static int shaderId_DepthTex;

	private static int shaderId_FovCosine;

	private static int shaderId_V_Mat;

	private static int shaderId_VP_Mat;

	private bool isTargetAvailable;

	private Transform target;

	public void SetTarget(Transform target)
	{
	}

	private void Awake()
	{
	}

	public void SetMaterialProperty(Renderer renderer, string property, float value)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
