using System;
using System.Collections.Generic;
using System.Reflection;

namespace Injection
{
	public sealed class Injector
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<FieldInfo, bool> _003C_003E9__5_0;

			internal bool _003CTryToMapFields_003Eb__5_0(FieldInfo temp)
			{
				return false;
			}
		}

		private readonly Dictionary<Type, FieldInfo[]> _fieldsMap;

		private readonly Context _context;

		public Injector(Context context)
		{
		}

		public void Inject(object value)
		{
		}

		public T Get<T>() where T : class
		{
			return null;
		}

		private void TryToMapFields(Type type)
		{
		}
	}
}
