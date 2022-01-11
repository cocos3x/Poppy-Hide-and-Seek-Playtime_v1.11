using UnityEngine;
using UnityEngine.UI;

public class DepthTest : MonoBehaviour
{
	public Camera camera;

	public RenderTexture depthTexture;

	public int textureWith;

	public int textureHeight;

	public float fov;

	public Shader depthReplacementShader;

	public Material materialView;

	public RawImage rawImage;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
