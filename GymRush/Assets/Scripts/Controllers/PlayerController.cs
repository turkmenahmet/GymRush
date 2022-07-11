using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    private float _hor;

    private float _moveSpeed = 5f;

    private float _swipeSpeed = 5f;

    private bool _isMoving;    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void MoveFunction(bool isMove)
    {
        _isMoving = isMove;

        if (_isMoving == false) return;

        if (_isMoving)
        {
            // FORWARD
            _hor = Input.GetAxis("Horizontal") * _swipeSpeed * Time.deltaTime;
            transform.Translate(_hor, 0, _moveSpeed * Time.deltaTime);

            // SWIPE LIMIT
            float xPos = Mathf.Clamp(transform.position.x, -1.4f, 1.4f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }

    public void FinishLine()
    {
        _swipeSpeed = 0;

        Vector3 temp = new Vector3(0, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(temp, transform.position, _moveSpeed * Time.deltaTime);
    }

    public void FreezeFunction()
    {
        _swipeSpeed = 0;
        _moveSpeed = 0;
    }

}
