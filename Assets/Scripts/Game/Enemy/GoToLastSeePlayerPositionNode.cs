using UnityEngine;
using UnityEngine.AI;

namespace Game.Enemy
{
	public sealed class GoToLastSeePlayerPositionNode : Node
	{
		private EnemyController _enemyController;

		private NavMeshAgent _meshAgent;

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
