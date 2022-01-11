using UnityEngine;

namespace Game.Core.UI
{
	public abstract class Mediator
	{
		public abstract void Unmediate();
	}
	public abstract class Mediator<T> : Mediator where T : MonoBehaviour
	{
		protected T _view;

		public void Mediate(T view)
		{
		}

		public override void Unmediate()
		{
		}

		protected abstract void Show();

		protected abstract void Hide();
	}
}
