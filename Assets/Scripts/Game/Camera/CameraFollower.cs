using UnityEngine;

namespace Game.Camera
{
	public sealed class CameraFollower : MonoBehaviour
	{
		public GameObject player;

		public float lerpFactor;

		public float Radius;

		public float ZoomDuration;

		private Vector3 difference;

		private Vector3 startPos;

		private Vector3 _clampedPosition;

		private Transform _transform;

		private Vector3 _defaultPosition;

		private float Zoom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void ResetToDefaultPosition()
		{
		}

		public void SetTarget(GameObject target)
		{
		}

		private void Update()
		{
		}

		public void ZoomTo(float zoom, float duration)
		{
		}

		private float _003CZoomTo_003Eb__16_0()
		{
			return 0f;
		}

		private void _003CZoomTo_003Eb__16_1(float x)
		{
		}
	}
}
