using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinCollector : MonoBehaviour
{
    private int copper = 0;
    [SerializeField] private Text cointext;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.CompareTag("collectable"))
        {
            Destroy(collision.gameObject);
            copper = copper + 2;
            cointext.text = "Copper:" + copper;
        }
    }
}

