using Game.Camera;
using Game.UI;
using Game.UI.Pool;
using UnityEngine;

public sealed class GameView : MonoBehaviour
{
	[SerializeField]
	public MenuHud MenuHud;

	[SerializeField]
	public GameHud GameHud;

	[SerializeField]
	public UnitsHolderHud UnitsHolderHud;

	[SerializeField]
	public EndGameHud EndGameHud;

	[SerializeField]
	public CameraFollower CameraFollower;

	[SerializeField]
	public ComponentPoolFactory CagesPool;

	[SerializeField]
	public Material[] OutlineMaterials;

	[SerializeField]
	public ComponentPoolFactory SparksEffectPool;

	[SerializeField]
	public ComponentPoolFactory StepsEffectPool;
}
