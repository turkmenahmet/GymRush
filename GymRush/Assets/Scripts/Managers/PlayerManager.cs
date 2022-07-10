using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private void Update()
    {
        MoveFunctionEnable();
    }
    private void MoveFunctionEnable()
    {
        PlayerController.instance.MoveFunction(true);
    }
}
