using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public static int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yes");
        score += 1;
    }
}
