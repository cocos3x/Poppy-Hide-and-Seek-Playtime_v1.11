using TMPro;
using UnityEngine;

namespace Game.UI
{
	public sealed class UnitsHolderHud : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] _greenHolders;

		[SerializeField]
		private GameObject[] _yellowHolders;

		[SerializeField]
		private TextMeshProUGUI _txtOnlyOneLeft;

		private int _count;

		private int _maxCount;

		private bool _isGreen;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SwitchToMode(bool isGreen, int maxCount)
		{
		}
	}
}
