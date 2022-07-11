using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerPowerScore.instance.BoxingScore();
            BoxingController.instance.BoxingFunction();
        }
    }
}
