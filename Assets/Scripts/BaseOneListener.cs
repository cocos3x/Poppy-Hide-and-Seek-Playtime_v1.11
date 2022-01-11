using System.Collections;
using System.Collections.Generic;

public abstract class BaseOneListener<T>  where T : class
{
	protected readonly List<T> _list;

	protected int _count;

	public int Count => 0;

	public void Add(T action)
	{
	}

	public void Remove(T action)
	{
	}

	public void RemoveAll()
	{
	}

	public bool Contains(T action)
	{
		return false;
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}
}
