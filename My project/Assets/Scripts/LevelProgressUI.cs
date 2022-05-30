using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelProgressUI : MonoBehaviour
{
    [Header("UI References :")]
    [SerializeField] private Image uiFillImage;
    [SerializeField] private TextMeshProUGUI uiStartText;
    [SerializeField] private TextMeshProUGUI uiEndText;

    [Header("Player & EndLine References :")]
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform endLineTransform;

    private Vector3 endLinePosition;

    private float fullDistance;

    private void Start()
    {
        endLinePosition = endLineTransform.position;
        fullDistance = GetDistance();
    }

    public void SetLevelTexts (int Level)
    {
        uiStartText.text = Level.ToString();
        uiEndText.text = (Level + 1).ToString();
    }

    private float GetDistance() 
    {
        // return Vector3.Distance(playerTransform.position,endLinePosition);
        return (endLinePosition - playerTransform.position).sqrMagnitude;
    }
    private void UpdateProgressFill(float value) 
    { 
    uiFillImage.fillAmount = value;
    }

    private void Update()
    {
        if(playerTransform.position.z < endLinePosition.z) 
        { 
        float newDistance = GetDistance();
        float progressValue = Mathf.InverseLerp(fullDistance, 0f ,newDistance);
        UpdateProgressFill(progressValue);
        }
    }

}