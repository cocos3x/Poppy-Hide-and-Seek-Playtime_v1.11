using UnityEngine;

namespace Game.Enemy
{
	public sealed class RotateByNode : Node
	{
		[SerializeField]
		private float _angle;

		private EnemyController _enemyController;

		private float _time;

		private float _startAngle;

		private float _startTime;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void Dispose()
		{
		}

		public override void Process()
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
