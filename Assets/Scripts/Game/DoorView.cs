using System;
using UnityEngine;

namespace Game
{
	public sealed class DoorView : MonoBehaviour
	{
		public Action<Collider> COLLISION;

		private const float kColliderRadius = 0.8f;

		[SerializeField]
		private BoxCollider _box;

		[SerializeField]
		private float _angleOffset;

		[SerializeField]
		private float _lerpFactor;

		[SerializeField]
		private float _speedFading;

		private float _speed;

		private float _angle;

		private float _startAngle;

		private Transform _lastDetectedCollisionTarget;

		private int _layerMask;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private float DirectionPointByTheLine(Vector3 position, Vector3 start, Vector3 end)
		{
			return 0f;
		}
	}
}
