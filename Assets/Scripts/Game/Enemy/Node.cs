using System;
using UnityEngine;

namespace Game.Enemy
{
	public abstract class Node : StateMachineBehaviour, IDisposable
	{
		private Animator _003CAnimator_003Ek__BackingField;

		protected Animator Animator
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool IsCompleted => false;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public abstract void Dispose();

		protected void NextNode()
		{
		}

		public abstract void Process();

		public override string ToString()
		{
			return "";
		}
	}
}
