using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Config
{
	[Serializable]
	public sealed class GameConfig
	{
		public const string Name = "config";

		public readonly Dictionary<GameParam, object> ParamsMap;

		public float GetValue(GameParam param)
		{
			return 0f;
		}


	}
}
