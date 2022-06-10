using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TapMenu : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject canvas;
    void Start()
    {
        canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            canvas.SetActive(false);
        }
    }
}
