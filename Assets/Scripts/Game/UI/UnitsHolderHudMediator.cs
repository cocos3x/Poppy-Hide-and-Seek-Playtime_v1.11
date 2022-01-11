using Game.Core.UI;

namespace Game.UI
{
	public sealed class UnitsHolderHudMediator : Mediator<UnitsHolderHud>
	{
		private GameManager _gameManager;

		private LevelView _levelView;

		private readonly bool _isHided;

		public UnitsHolderHudMediator(bool isHided)
		{
		}

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void OnUnitKilled(UnitView obj)
		{
		}

		private void OnUnitRescued(UnitView obj)
		{
		}
	}
}
