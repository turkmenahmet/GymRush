using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DumbbellController : MonoBehaviour
{
    public static DumbbellController instance;

    private float xScale, yScale, zScale;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void DumbbellFunction()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale += 0.035f;
        yScale += 0.035f;
        zScale += 0.035f;

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);
    }

    public void FlashScale()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale += 0.5f;
        yScale += 0.5f;
        zScale += 0.5f;
            
        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);

        Invoke("FlashScaleOut", 0.5f);
    }

    private void FlashScaleOut()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale -= 0.5f;
        yScale -= 0.5f;
        zScale -= 0.5f;

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);
    }
}
