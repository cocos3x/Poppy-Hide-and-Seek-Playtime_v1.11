using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
	public sealed class MenuHud : MonoBehaviour
	{
		[SerializeField]
		public Button BtnSeek;

		[SerializeField]
		public Button BtnHide;

		[SerializeField]
		public TextMeshProUGUI TxtLevelName;
	}
}
