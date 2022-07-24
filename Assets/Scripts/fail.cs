using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fail : MonoBehaviour
{
    

    
    

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "blockers")
        {

            
            Time.timeScale = 0;
            PlayerManager.isGameOver = true;
            



        }

    }
}
