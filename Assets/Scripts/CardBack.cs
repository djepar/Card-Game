using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour
{

    public GameObject cardBack;
    /// <summary>
    ///Start is called before the first frame update
    ///</summary>
    void Start()
    {
        
    }
    ///<summary>
    /// Update is called once per frame
    ///</summary>
    void Update()
    {
        if(CardDisplay.staticCardBack == true)
        {
            cardBack.SetActive(true);
        }
        else
        {
            cardBack.SetActive(false);
        }
    }
}

