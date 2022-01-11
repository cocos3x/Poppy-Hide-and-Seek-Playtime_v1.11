using UnityEngine;

namespace Game
{
	public sealed class CoinView : MonoBehaviour
	{
		[SerializeField]
		private float _shakeScaleDuration;

		[SerializeField]
		private float _hideScaleDuration;

		[SerializeField]
		public int Value;

		public void Collect()
		{
		}

		private void Update()
		{
		}
	}
}
