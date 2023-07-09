using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeController : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-2, 2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Empty"))
        {
            GameFlows.SetULStatus("R");
            Destroy(gameObject);
        }
        else if (other.CompareTag(GameFlows.GetCurrentPlayerMove()))
        {
            GameFlows.SetULStatus("Y");
            Destroy(gameObject);
        }
        else
        {
            other.tag = gameObject.tag;
        }
    }
}
