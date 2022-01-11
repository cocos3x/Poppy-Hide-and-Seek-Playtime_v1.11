using UnityEngine;

namespace Game
{
	public sealed class CircleRadarView : MonoBehaviour
	{
		[SerializeField]
		private MeshFilter _meshFilter;

		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private float _radius;

		[SerializeField]
		private int _segments;

		private Vector3[] _vertices;

		private Vector2[] _uvs;

		private float[] _distances;

		private float[] _tempDistances;

		private Vector3[] _tempVertices;

		private Vector2[] _tempUvs;

		private float[] _linecastDistances;

		private bool _isEven;

		private Mesh _mesh;

		private int _layerMask;

		private int _victimLayerMask;

		private void OnEnable()
		{
		}

		public Collider GetSeenVictim()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		
	}
}
