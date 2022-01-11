using System;

public sealed class OneListener : BaseOneListener<Action>
{
	public void Invoke()
	{
	}
}
public sealed class OneListener<T> : BaseOneListener<Action<T>>
{
	public void Invoke(T value)
	{
	}
}
public sealed class OneListener<T1, T2> : BaseOneListener<Action<T1, T2>>
{
	public void Invoke(T1 value1, T2 value2)
	{
	}
}
public sealed class OneListener<T1, T2, T3> : BaseOneListener<Action<T1, T2, T3>>
{
	public void Invoke(T1 value1, T2 value2, T3 value3)
	{
	}
}
public sealed class OneListener<T1, T2, T3, T4> : BaseOneListener<Action<T1, T2, T3, T4>>
{
	public void Invoke(T1 value1, T2 value2, T3 value3, T4 value4)
	{
	}
}
