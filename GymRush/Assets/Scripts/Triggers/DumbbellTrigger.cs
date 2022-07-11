using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbbellTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DumbbellController.instance.DumbbellFunction();
            PlayerPowerScore.instance.DumbbellScore();
            Destroy(this.gameObject);
        }
    }
}
