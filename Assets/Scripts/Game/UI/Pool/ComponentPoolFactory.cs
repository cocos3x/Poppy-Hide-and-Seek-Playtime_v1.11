using System.Collections.Generic;
using UnityEngine;

namespace Game.UI.Pool
{
	public class ComponentPoolFactory : MonoBehaviour, IComponentPoolFactory
	{
		[SerializeField]
		private GameObject _prefab;

		[SerializeField]
		private int _count;

		[SerializeField]
		private Transform _content;

		[SerializeField]
		private Transform _poolStorage;

		private readonly HashSet<GameObject> _instances;

		private Queue<GameObject> _pool;

		public Transform Content => null;

		public int CountInstances => 0;

		private void Awake()
		{
		}

		public T Get<T>() where T : Component
		{
			return null;
		}

		public T Get<T>(int sublingIndex) where T : Component
		{
			return null;
		}

		public void Release<T>(T component) where T : Component
		{
		}

		public void ReleaseAllInstances()
		{
		}

		public void PutInstancesToPool()
		{
		}

		public void HideUnusedInstances()
		{
		}

		public void Dispose()
		{
		}
	}
}
