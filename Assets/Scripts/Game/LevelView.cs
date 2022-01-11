using System;
using UnityEngine;

namespace Game
{
	public sealed class LevelView : MonoBehaviour
	{
		[NonSerialized]
		public UnitView[] Units;

		[NonSerialized]
		public CoinView[] Coins;

		[NonSerialized]
		public DoorView[] Doors;

		[SerializeField]
		public float Duration;

		private void Awake()
		{
		}
	}
}
