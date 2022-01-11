using UnityEngine;

public class CameraDumping : MonoBehaviour
{
	public Shader replacementShader;

	public RenderTexture renderTexture;

	public Mesh mesh;

	public Material material;

	private Camera camera;

	public bool drawNow;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void SaveRenderTextureToFile(string filePath)
	{
	}
}
