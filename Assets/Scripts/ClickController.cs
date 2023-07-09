using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    public Transform tokenWhiteObject;
    public Transform tokenBlackObject;
    public Transform probeObject;

    private void OnMouseDown()
    {
        if (GameFlows.GetCurrentPlayerMove() == "W")
        {
            Instantiate(tokenWhiteObject, transform.position, tokenWhiteObject.rotation);
            StartCoroutine(WaitChangePlayerMove("B"));
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeObject, transform.position, probeObject.rotation);
        }
        else if (GameFlows.GetCurrentPlayerMove() == "B")
        {
            Instantiate(tokenBlackObject, transform.position, tokenBlackObject.rotation);
            StartCoroutine(WaitChangePlayerMove("W"));
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeObject, transform.position, probeObject.rotation);
        }
    }

    private IEnumerator WaitChangePlayerMove(string nextMove)
    {
        yield return new WaitForSeconds(6);
        GameFlows.SetCurrentPlayerMove(nextMove);
        GameFlows.SetULStatus("N");
    }
}
