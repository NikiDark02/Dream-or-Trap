using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UniversalNPC : MonoBehaviour
{
    [SerializeField] private Image backr;
    [SerializeField] private TextMeshProUGUI textt;
    [SerializeField] private string message;

    public void Set_D()
    {
        textt.text = message;
    }
}
