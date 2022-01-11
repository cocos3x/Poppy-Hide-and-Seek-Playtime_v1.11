using System;
using UnityEngine;

namespace Utilities
{
	public static class MathUtil
	{
		private static float secPerYear;

		private static System.Random _random;

		public static bool RandomBool => false;

		public static int RandomSign => 0;

		public static void SetSecPerYear(float value)
		{
		}

		public static float YearsToSec(float years)
		{
			return 0f;
		}

		public static float SecToYears(float value)
		{
			return 0f;
		}

		public static string FloatToString(float value, int decim)
		{
			return "";
		}

		public static float SecToMos(float value)
		{
			return 0f;
		}

		public static string LongToString(long cash, string prefix = "", string suffixTimeUnit = "")
		{
			return "";
		}

		public static long IntToLong(int value)
		{
			return 0L;
		}

		public static float HoursToSeconds(float value)
		{
			return 0f;
		}

		public static string SecondsToHours(float value)
		{
			return "";
		}

		public static string SecondsToMinutes(float value)
		{
			return "";
		}

		static MathUtil()
		{
		}

		public static void InitSeed(int seed)
		{
		}

		public static float GetAngle(Vector3 start, Vector3 end)
		{
			return 0f;
		}

		public static float GetAngle(Vector2 start, Vector2 end)
		{
			return 0f;
		}

		public static long Lerp(double a, double b, float t)
		{
			return 0L;
		}

		public static int Sign(double value)
		{
			return 0;
		}

		public static int RandomSystem(int min, int max)
		{
			return 0;
		}

		public static float RandomSystem(float min, float max)
		{
			return 0f;
		}

		public static int Random(int min, int max)
		{
			return 0;
		}

		public static float Random(float min, float max)
		{
			return 0f;
		}

		public static string IntToHex(uint crc)
		{
			return "";
		}

		public static uint HexToInt(string crc)
		{
			return 0u;
		}

	
	}
}
