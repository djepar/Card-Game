using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class CardDisplay : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int strenght;
    public int health;
    public string cardDescription;


    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text strenghtText;
    public TMP_Text healthText;
    public TMP_Text descriptionText;


    /// <summary>
    ///Start is called before the first frame update
    ///</summary>
    void Start()
    {
        ///  Debug.Log(CardDatabase.cardList[2].cardName); 
        Card card = CardDatabase.cardList[displayId];
        displayCard.Add(card);

        Debug.Log(displayCard[0].id);
    }
    ///<summary>
    /// Update is called once per frame
    ///</summary>
    void Update()
    {
        id = displayCard[0].id;
        cost = displayCard[0].cost;
        cardName = displayCard[0].cardName;
        strenght = displayCard[0].strenght;
        health = displayCard[0].health;
        cardDescription = displayCard[0].cardDescription;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        strenghtText.text = " " + strenght;
        healthText.text = " " + health;
        descriptionText.text = " " + cardDescription;


    }
}

