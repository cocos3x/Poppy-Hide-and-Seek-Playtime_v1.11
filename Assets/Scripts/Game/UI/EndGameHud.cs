using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
	public sealed class EndGameHud : MonoBehaviour
	{
		[SerializeField]
		public Button BtnRestart;

		[SerializeField]
		public TextMeshProUGUI TxtRestartLabel;

		public string RestartLabel
		{
			set
			{
			}
		}
	}
}
