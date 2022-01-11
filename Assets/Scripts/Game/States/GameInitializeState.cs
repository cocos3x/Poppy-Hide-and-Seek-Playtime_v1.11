using Game.Config;
using Injection;

namespace Game.States
{
	public sealed class GameInitializeState : GameState
	{
		private GameStateManager _gameStateManager;

		private Context _context;

		public static GameConfig LoadConfig()
		{
			return null;
		}

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}
	}
}
