using Game.Config;
using System;
using UnityEngine;

namespace Game
{
	[SerializeField]
	public sealed class GameModel
	{
		[NonSerialized]
		public Action Changed;

		public int Level;

		[NonSerialized]
		public bool IsTimeOut;

		[NonSerialized]
		public Vector4 LevelBounds;

		public static GameModel Load(GameConfig config)
		{
			return null;
		}

		public GameModel()
		{
		}

		public GameModel(GameConfig config)
		{
		}

		public void SetChanged()
		{
		}

		public void Save()
		{
		}

		public void Remove()
		{
		}
	}
}
