using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textt;
    private bool inrange = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AAA"))
        {
            inrange = true;
            collision.gameObject.GetComponent<UniversalNPC>().Set_D();
                
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AAA"))
        {
            inrange = true;
        }

    }
    private void Update()
    {
        if (inrange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                textt.enabled = true;
            }
        }
        else
        {
            textt.enabled = false;
        }
    }

}

