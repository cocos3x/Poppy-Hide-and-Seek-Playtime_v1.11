using UnityEngine;

public static class TouchUtility
{
	private static bool enabled;

	public static bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int TouchCount => 0;

	public static bool TouchedUI(int fingerId)
	{
		return false;
	}


}
