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
    public Sprite spriteImage;

    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text strenghtText;
    public TMP_Text healthText;
    public TMP_Text descriptionText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;


    /// <summary>
    ///Start is called before the first frame update
    ///</summary>
    void Start()
    {

        Card card = CardDatabase.cardList[displayId];
        displayCard.Add(card);

        id = displayCard[0].id;
        cost = displayCard[0].cost;
        cardName = displayCard[0].cardName;
        strenght = displayCard[0].strenght;
        health = displayCard[0].health;
        cardDescription = displayCard[0].cardDescription;
        artImage = GetComponent<Image>();
        artImage.sprite = spriteImage;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        strenghtText.text = " " + strenght;
        healthText.text = " " + health;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = spriteImage;

    }
    ///<summary>
    /// Update is called once per frame
    ///</summary>
    void Update()
    {
        staticCardBack = cardBack;
    }
}

