using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class InGameUI : MonoBehaviour
{
    public static InGameUI instance;

    [SerializeField] Image _bicepsImg;

    [SerializeField] Image _popUpImg;

    [SerializeField] TextMeshProUGUI _playerPowerText;

    [SerializeField] TextMeshProUGUI _limitText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void BicepsPopUp()
    {
        _bicepsImg.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutFlash);
        _bicepsImg.GetComponent<CanvasGroup>().DOFade(1, 0.5f);

        Invoke("BicepsPopUpOut", 1f);
    }

    private void BicepsPopUpOut()
    {
        _bicepsImg.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InOutFlash);
        _bicepsImg.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
    }

    public void PowerfulPopUp()
    {
        _popUpImg.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutFlash);
        _popUpImg.GetComponent<CanvasGroup>().DOFade(1, 0.5f);

        Invoke("PowerfulPopUpOut", 1f);
    }

    private void PowerfulPopUpOut()
    {
        _popUpImg.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InOutFlash);
        _popUpImg.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
    }

    public void TextUnshow()
    {
        _playerPowerText.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
    }

    public void TextScalePopUp()
    {
        _playerPowerText.GetComponent<RectTransform>().DOScale(0.1125f, 0.5f).SetEase(Ease.OutFlash);

        Invoke("TextScalePopUpOut", 0.5f);
    }

    private void TextScalePopUpOut()
    {
        _playerPowerText.GetComponent<RectTransform>().DOScale(0.1f, 0.5f).SetEase(Ease.InOutFlash);
    }

    public void LimitText()
    {
       
    }
}
