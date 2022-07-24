using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using TMPro;
public class leftwall : MonoBehaviour
{

    leftwallcounter lleftwallcounter;
    [SerializeField] GameObject wallleft;
    public TextMeshProUGUI cnText;

    void Awake()
    {
        lleftwallcounter = wallleft.GetComponent<leftwallcounter>();
    }

    // Update is called once per frame
    void Update()
    {


        cnText.text = lleftwallcounter.count.ToString();

    }
}
