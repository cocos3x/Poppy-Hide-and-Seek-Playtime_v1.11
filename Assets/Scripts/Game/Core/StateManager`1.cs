using Injection;
using System;
using System.Collections.Generic;

namespace Game.Core
{
	public class StateManager<T> : IDisposable where T : State
	{
		protected readonly OneListener<T> _onChangeState;

		protected Injector _injector;

		private readonly Dictionary<Type, T> _statesMap;

		protected T _state;

		public virtual T Current
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public event Action<T> CHANGE_STATE
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Dispose()
		{
		}

		public void SwitchToState(T state)
		{
		}

		public void SwitchToState(Type type)
		{
		}
	}
}
