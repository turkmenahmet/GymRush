using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoxingController : MonoBehaviour
{
    public static BoxingController instance;

    private float xScale, yScale, zScale;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void BoxingFunction()
    {
        // TEMP SCALE VALUES 
        xScale = this.transform.localScale.x;
        yScale = this.transform.localScale.y;
        zScale = this.transform.localScale.z;

        // SCALING
        xScale += 0.05f;
        yScale += 0.05f;
        zScale += 0.05f;

        // INCREASE SCALE 0.15F
        this.transform.DOScaleX(xScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleY(yScale, 0.25f).SetEase(Ease.InOutSine);
        this.transform.DOScaleZ(zScale, 0.25f).SetEase(Ease.InOutSine);
    }
}
