using Game.Config;
using UnityEngine;
using UnityEngine.AI;

namespace Game.Enemy
{
	public sealed class PathToRandomPositionNode : Node
	{
		private GameModel _model;

		private EnemyController _enemyController;

		private LevelView _levelView;

		private GameConfig _config;

		private NavMeshAgent _meshAgent;

		private float _previousDistanceToEnemy;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void Dispose()
		{
		}

		public override void Process()
		{
		}
	}
}
