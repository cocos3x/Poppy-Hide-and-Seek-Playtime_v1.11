using UnityEngine;

public class SaveRenderTexture : MonoBehaviour
{
	public Camera camera;

	public int width;

	public int height;

	private RenderTexture renderTexture;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Update()
	{
	}

	public void SaveTexture()
	{
	}

	private Texture2D toTexture2D(RenderTexture rTex)
	{
		return null;
	}
}
