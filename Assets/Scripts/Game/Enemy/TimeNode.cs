using UnityEngine;

namespace Game.Enemy
{
	public class TimeNode : Node
	{
		[SerializeField]
		private float _time;

		private float _endTime;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void Dispose()
		{
		}

		public override void Process()
		{
		}

		protected virtual void Completed()
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
