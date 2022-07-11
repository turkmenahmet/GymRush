using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public static AnimatorManager instance;

    Animator _playerAnim;

    Animation _strongAnim;

    private int _punchIndex, _strongIndex;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }        
    }

    private void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _punchIndex = _playerAnim.GetLayerIndex("Punch");
        _strongIndex = _playerAnim.GetLayerIndex("Strong");
    }

    public void DeadAnimation()
    {
        _playerAnim.SetLayerWeight(_strongIndex, 0);
        _playerAnim.SetLayerWeight(_punchIndex, 0);
        _playerAnim.Play("DyingAnimation");        
    }

    public void PunchAnimation()
    {
        _playerAnim.SetLayerWeight(_strongIndex, 0);
        _playerAnim.SetLayerWeight(_punchIndex, 1);
    }

    public void StrongAnimation()
    {
        _playerAnim.SetLayerWeight(_punchIndex, 0);
        _playerAnim.SetLayerWeight(_strongIndex, 1);
        
    }
}
