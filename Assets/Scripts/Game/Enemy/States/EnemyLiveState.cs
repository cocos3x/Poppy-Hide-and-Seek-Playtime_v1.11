using Game.Core;
using Injection;
using UnityEngine;

namespace Game.Enemy.States
{
	public sealed class EnemyLiveState : EnemyState
	{
		private Timer _timer;

		private EnemyController _enemyController;

		private Injector _injector;

		private GameManager _gameManager;

		private Node _currentNode;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void NodeEntered(Node node)
		{
		}

		private void TimerOnPOST_TICK()
		{
		}

		private void OnHearUnit(Vector3 position)
		{
		}
	}
}
