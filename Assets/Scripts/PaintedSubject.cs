using UnityEngine;

public class PaintedSubject : MonoBehaviour
{
	public RenderTexture mainTexture;

	public int textureSize;

	private Mesh mesh;

	public RenderTexture targetTexture1;

	public RenderTexture targetTexture2;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void RenderUVSpace(Material fixUVIslandMaterial)
	{
	}
}
