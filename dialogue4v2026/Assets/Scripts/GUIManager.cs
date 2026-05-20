using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GUIManager : MonoBehaviour
{

    // public GameObject Canvas;
    // public static GUIManager Instance;

    public TextMeshProUGUI txtQuantity;

    void OnEnable()
    {
        EventTriggers.OnLoaded += Load;
    }

    void OnDisable()
    {
        EventTriggers.OnLoaded -= Load;
    }

    private void Load(int value)
    {
        txtQuantity.text = $"{value}";
    }
}