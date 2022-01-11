using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
	protected static T instance;

	public bool dontDestroyOnLoad;

	protected bool isDuplicateIntance;

	public static T Instance => null;

	public static bool IsInstanceExisting => false;

	public virtual void Awake()
	{
	}
}
