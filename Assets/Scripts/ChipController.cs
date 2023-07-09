using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipController : MonoBehaviour
{
    private string currentColor;

    private void Start()
    {
        currentColor = gameObject.tag;
        GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(DelayActivation());
    }

    private void Update()
    {
        if (gameObject.CompareTag("UL"))
        {
            if ((GameFlows.GetULStatus() == "Y") && (currentColor == "B"))
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
                gameObject.tag = "W";
            }
            else if ((GameFlows.GetULStatus() == "Y") && (currentColor == "W"))
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                gameObject.tag = "B";
            }
            else if ((GameFlows.GetULStatus() == "R") && (currentColor == "B"))
            {
                gameObject.tag = "B";
            }
            else if ((GameFlows.GetULStatus() == "R") && (currentColor == "W"))
            {
                gameObject.tag = "W";
            }
        }
    }

    private IEnumerator DelayActivation()
    {
        yield return new WaitForSeconds(2);
        GetComponent<CircleCollider2D>().enabled = true;
    }
}
