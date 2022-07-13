using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public static BrickController instance;

    Rigidbody _rb;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _rb = GetComponent<Rigidbody>();
    }

    public void SmashForce()
    {
        _rb.mass = 0.1f;
        _rb.isKinematic = false;
        _rb.useGravity = true;
        _rb.AddForce(Vector3.forward * 100);
    }
}
