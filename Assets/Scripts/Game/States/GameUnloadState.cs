using UnityEngine.SceneManagement;

namespace Game.States
{
	public sealed class GameUnloadState : GameState
	{
		private GameStateManager _gameStateManager;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void SceneManagerOnsceneUnloaded(Scene scene)
		{
		}
	}
}
