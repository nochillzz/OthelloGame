using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlows : MonoBehaviour
{
    public Transform squareObject;
    private static string currentPlayerMove = "W";
    private static string ulStatus = "N";

    public static string GetCurrentPlayerMove()
    {
        return currentPlayerMove;
    }

    public static void SetCurrentPlayerMove(string move)
    {
        currentPlayerMove = move;
    }

    public static string GetULStatus()
    {
        return ulStatus;
    }

    public static void SetULStatus(string status)
    {
        ulStatus = status;
    }

    private void Start()
    {
        for (float y = 4; y > -5; y -= 1.2f)
        {
            for (float x = -4; x < 5; x += 1.2f)
            {
                Instantiate(squareObject, new Vector2(x, y), squareObject.rotation);
            }
        }
    }
}
