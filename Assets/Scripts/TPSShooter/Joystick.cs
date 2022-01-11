using UnityEngine;
using UnityEngine.EventSystems;

namespace TPSShooter
{
	public class Joystick : MonoBehaviour
	{
		private enum JoystickUsedType
		{
			None,
			Touch,
			Mouse,
			Keyboard
		}

		[SerializeField]
		private GameObject circle;

		[SerializeField]
		private GameObject dot;

		private Vector2 touchPosition;

		private Vector2 moveDirection;

		public float maxRadius;

		public bool IsTouched;

		public float Horizontal;

		public float Vertical;

		private float speedKoef;

		private BaseInput _input;

		private float _lastAxisUsedTime;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void MovePlayer()
		{
		}

	
	}
}
