using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
	public Material uvSpaceMaterial;

	public Material fixUVIslandMaterial;

	public float brushSize;

	public Color color;

	public List<PaintedSubject> subjects;

	public RenderTexture depthTexture;

	public int textureSize;

	public Texture2D brushTexture;

	public Shader depthReplacementShader;

	private Camera camera;

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

	private void RenderToDepthTexture()
	{
	}

	public void Paint()
	{
	}
}
