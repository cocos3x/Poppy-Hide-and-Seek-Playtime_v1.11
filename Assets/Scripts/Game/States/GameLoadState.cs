using Game.Config;
using Injection;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.States
{
	public sealed class GameLoadState : GameState
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Vector3, float> _003C_003E9__5_0;

			public static Func<Vector3, float> _003C_003E9__5_1;

			public static Func<Vector3, float> _003C_003E9__5_2;

			public static Func<Vector3, float> _003C_003E9__5_3;

			internal float _003CSceneManagerOnSceneLoaded_003Eb__5_0(Vector3 temp)
			{
				return 0f;
			}

			internal float _003CSceneManagerOnSceneLoaded_003Eb__5_1(Vector3 temp)
			{
				return 0f;
			}

			internal float _003CSceneManagerOnSceneLoaded_003Eb__5_2(Vector3 temp)
			{
				return 0f;
			}

			internal float _003CSceneManagerOnSceneLoaded_003Eb__5_3(Vector3 temp)
			{
				return 0f;
			}
		}

		private GameConfig _config;

		private Context _context;

		private GameStateManager _gameStateManager;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode arg1)
		{
		}
	}
}
