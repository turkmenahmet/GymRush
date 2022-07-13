using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _uiFillImage;
    [SerializeField] private TextMeshProUGUI _uiStartText;
    [SerializeField] private TextMeshProUGUI _uiEndText;

    [SerializeField] private Transform _player;
    [SerializeField] private Transform _endLineTransform;

    private Vector3 _endLinePosition;
    private float _fullDistance;

    private void Start()
    {
        _endLinePosition = _endLineTransform.position;
        _fullDistance = GetDistance();
    }

    private void Update()
    {
        float newDistance = GetDistance();
        float progressValue = Mathf.InverseLerp(_fullDistance, 0f, newDistance);

        UpdateProgressFill(progressValue);
    }

    public void SetLevelTexts(int level)
    {
        _uiStartText.text = level.ToString();
        _uiEndText.text = (level + 1).ToString();
    }

    private float GetDistance()
    {
        return Vector3.Distance(_player.position, _endLinePosition);
    }

    private void UpdateProgressFill(float value)
    {
        _uiFillImage.fillAmount = value;
    }
}
