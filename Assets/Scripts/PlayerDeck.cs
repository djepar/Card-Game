using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    int x;

    /// <summary>
    ///Start is called before the first frame update
    ///</summary>
    void Start()
    {
        x = 0;

        for(int i = 0; i < deck.Count; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x];
        }
    }
    ///<summary>
    /// Update is called once per frame
    ///</summary>
    void Update()
    {
        
    }
    public void Shuffle()
    {
        for(int i =0; i < deck.Count; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
}

