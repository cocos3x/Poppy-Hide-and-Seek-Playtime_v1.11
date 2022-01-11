using DG.Tweening;
using UnityEngine;

public class RectTransformSnapPoint
{
	public RectTransform rectTransform;

	public Vector2 initializedPosition;

	public Vector2 targetPosition;

	public RectTransformSnapPoint(RectTransform rt, float deltaX, float deltaY, bool moveTo = false)
	{
	}

	public Tween MoveToTargetPosition(float duration, bool resetAtStart = true)
	{
		return null;
	}

	public Tween MoveToInitializedPosition(float duration, bool resetAtStart = true)
	{
		return null;
	}

	public void ResetToInitializedPosition()
	{
	}
}
