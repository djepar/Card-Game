
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake()
    {
        cardList.Add(new Card(0, "None", 555, 0, 5, "None"));
        cardList.Add(new Card(1, "Archer", 1, 1, 1, "An archer"));
        cardList.Add(new Card(2, "Infantry", 1, 2, 2, "An infantry"));
        cardList.Add(new Card(3, "Cavalry", 2, 3, 3, "A calary"));
        cardList.Add(new Card(4, "Worker", 0, 0, 2, "This is a worker"));
    }
}
