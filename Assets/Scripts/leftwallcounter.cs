using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class leftwallcounter : MonoBehaviour
{
    
    
    public int count = 0;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;

    }


  



}
