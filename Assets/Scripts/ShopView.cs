using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopView : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__26_1;

		internal void _003CButtonUnlockByAdsClicked_003Eb__26_1()
		{
		}
	}

	public CharacterPreview characterPreview;

	public TextMeshProUGUI textCash;

	public RawImage rawImage;

	public GameObject blocker;

	public GameObject buttonNextPage;

	public GameObject buttonPrevPage;

	public GameObject unlockButtons;

	public Action<int> OnCashUpdated;

	public AnimationCurve unlockRandomTimeCurve;

	public SelectionPageView[] pages;

	public Image[] dotImages;

	public RectTransform selectionDotRectTransform;

	private int pageIndex;

	private RenderTexture previewTargetTexture;

	private string previousHiderId;

	private string previousSeekerId;

	public Action OnHiderIdChange;

	public Action OnSeekerIdChange;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void NextPageClicked()
	{
	}

	public void PrevPageClicked()
	{
	}

	private void OnPageChange(int newPageIndex)
	{
	}

	public void ButtonUnlockByCashClicked()
	{
	}

	public void ButtonUnlockByAdsClicked()
	{
	}

	private void UpdateTextCash()
	{
	}

	private bool IsSeeker(string id)
	{
		return false;
	}

	private void _003CAwake_003Eb__18_0(bool unlock, string id)
	{
	}

	private void _003CAwake_003Eb__18_1(bool unlock, string id)
	{
	}

	private void _003CButtonUnlockByCashClicked_003Eb__25_0()
	{
	}

	private void _003CButtonUnlockByAdsClicked_003Eb__26_0()
	{
	}
}
