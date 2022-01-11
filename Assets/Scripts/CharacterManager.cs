using System;
using System.Collections.Generic;

public class CharacterManager : SingletonMonoBehaviour<CharacterManager>
{
	[Serializable]
	public class HiderData
	{
		public string id;

		public Hider prefab;
	}

	[Serializable]
	public class SeekerData
	{
		public string id;

		public Seeker prefab;
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string id;

		internal bool _003CGetSeekerPrefab_003Eb__0(Seeker x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string id;

		internal bool _003CGetHiderPrefab_003Eb__0(Hider x)
		{
			return false;
		}
	}

	public List<Seeker> seekerPrefabs;

	public List<Hider> hiderPrefabs;

	public List<Hider> hiders;

	public Seeker seeker;

	public Seeker GetSeekerPrefab(string id)
	{
		return null;
	}

	public Hider GetHiderPrefab(string id)
	{
		return null;
	}

	public void Spawn()
	{
	}

	public void ReplaceHider(int index, Hider newHiderPrefab)
	{
	}

	public void ReplaceSeeker(Seeker newSeekerPrefab)
	{
	}

	public void Clear()
	{
	}

	public void GetRefs()
	{
	}
}
