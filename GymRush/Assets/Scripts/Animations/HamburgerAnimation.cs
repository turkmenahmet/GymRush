using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HamburgerAnimation : MonoBehaviour
{
    private Vector3 _originalScale;
    private Vector3 _scaleTo;

    private void Start()
    {
        _originalScale = transform.localScale;
        _scaleTo = _originalScale * 1.25f;

        OnScale();
    }

    private void OnScale()
    {
        transform.DOScale(_scaleTo, 1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
