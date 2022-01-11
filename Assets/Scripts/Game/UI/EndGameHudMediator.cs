using Game.Core.UI;
using Game.States;

namespace Game.UI
{
	public sealed class EndGameHudMediator : Mediator<EndGameHud>
	{
		private GameModel _gameModel;

		private GameStateManager _gameStateManager;

		private readonly bool _isWin;

		public EndGameHudMediator(bool isWin)
		{
		}

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void OnRestartClicked()
		{
		}

		public void NextLevel(bool isWin)
		{
		}

		private void _003COnRestartClicked_003Eb__6_0()
		{
		}

		private void _003COnRestartClicked_003Eb__6_1()
		{
		}

		private void _003COnRestartClicked_003Eb__6_2()
		{
		}
	}
}
