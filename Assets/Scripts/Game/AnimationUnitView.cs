using UnityEngine;

namespace Game
{
	public abstract class AnimationUnitView : BaseUnitView
	{
		[SerializeField]
		private Animator _animator;

		private AnimationType _animationType;

		

		public bool IsDied()
		{
			return false;
		}

		public virtual void Idle()
		{
		}

		public void Walk()
		{
		}

		public virtual void Die()
		{
		}

		private void PlayAnimation(AnimationType animationType)
		{
		}
	}
}
