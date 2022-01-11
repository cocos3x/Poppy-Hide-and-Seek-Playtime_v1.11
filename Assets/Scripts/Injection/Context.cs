using System;
using System.Collections.Generic;

namespace Injection
{
	public sealed class Context
	{
		private readonly Dictionary<Type, object> _objectsMap;

		public Context()
		{
		}

		public Context(Context parent)
		{
		}

		public void Install(params object[] objects)
		{
		}

		public void ApplyInstall()
		{
		}

		public void Uninstall(params object[] objects)
		{
		}

		public T Get<T>() where T : class
		{
			return null;
		}

		public object Get(Type type)
		{
			return null;
		}
	}
}
