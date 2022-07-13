using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPowerScore : MonoBehaviour
{
    public static PlayerPowerScore instance;

    [SerializeField] private TextMeshProUGUI _playerPowerText;

    private int _playerPower;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _playerPower = 0;
    }

    public void DumbbellScore()
    {
        _playerPower += 10;
        _playerPowerText.text = _playerPower.ToString();

        if (_playerPower % 30 == 0)
        {
            DumbbellController.instance.FlashScale();
            InGameUI.instance.BicepsPopUp();
            InGameUI.instance.TextScalePopUp();
            AnimatorManager.instance.StrongAnimation();
        }
    }

    public void HamburgerScore()
    {
        _playerPower -= 10;
        _playerPowerText.text = _playerPower.ToString();

        if (_playerPower < 0)
        {
            _playerPower = 0;
            _playerPowerText.text = _playerPower.ToString();
            InGameUI.instance.TextUnshow();
            PlayerController.instance.FreezeFunction();
            AnimatorManager.instance.DeadAnimation();
        }
    }

    public void BoxingScore()
    {
        if (_playerPower >= 70)
        {
            _playerPower += 20;
            _playerPowerText.text = _playerPower.ToString();

            InGameUI.instance.PowerfulPopUp();
            InGameUI.instance.TextScalePopUp();
            AnimatorManager.instance.StrongAnimation();
        }
        if (_playerPower < 70)
        {
            InGameUI.instance.TextUnshow();
            PlayerController.instance.FreezeFunction();
            AnimatorManager.instance.DeadAnimation();
        }
    }
}
