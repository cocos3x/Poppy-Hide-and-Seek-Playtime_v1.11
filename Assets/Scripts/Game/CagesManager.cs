using Game.Core.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public sealed class CagesManager : Mediator<GameView>
	{
		private GameManager _gameManager;

		private readonly Dictionary<AnimationUnitView, Transform> _cagesMap;

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		private void UnitKilled(AnimationUnitView unit)
		{
		}

		private void UnitRescued(AnimationUnitView unit)
		{
		}
	}
}
