using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InGameUI.instance.TextUnshow();
            PlayerController.instance.FinishLine();
            AnimatorManager.instance.PunchAnimation();
        }
    }
}
