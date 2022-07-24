using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{

    public static bool score = false;

    private void Awake()
    {
        score = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "score")
        {

            Destroy(gameObject);
            score = true;
            //or gameObject.SetActive(false);
        }
 
    }
}
