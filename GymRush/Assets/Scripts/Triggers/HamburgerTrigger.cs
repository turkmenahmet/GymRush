using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamburgerTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HamburgerController.instance.HamburgerFunction();
            PlayerPowerScore.instance.HamburgerScore();
            Destroy(this.gameObject);
        }
    }
}

