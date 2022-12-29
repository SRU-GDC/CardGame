using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManger : MonoBehaviour
{
    //Reference to other Scripts
    CardObject cardObject;

    //Variables
    //Ui Text on cavnas
    public TextMeshProUGUI deckSizeCount;
    
    //List will contain all cards in the deck
    public List<CardObject> deck;
    //Array holds cardsSlots
    public Transform[] cardSlots;
    //Check how many slots can be filled/need filled
    public bool[] availableCardSlots;

    //Update's game per frame rate
    private void Update()
    {
        deckSizeCount.text = deck.Count.ToString();
    }

    //Method to Draw out cards and place them in any avilable Card Slot
    public void DrawCard()
    {
        //Check if any cards are avaiable before adding in a random card
        if (deck.Count >= 1)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                cardObject = deck[i];

                //Loop through to check how many slots are available
                for (int j = 0; j < availableCardSlots.Length; j++)
                {
                    if (availableCardSlots[j] == true)
                    {
                        //Grabs the given random card
                        cardObject.gameObject.SetActive(true);
                        cardObject.handIndex = j;
                        //Places that card in one of the card Slots avaiable
                        cardObject.transform.position = cardSlots[j].position;
                        cardObject.locatedinDeck = false;
                        deck.Remove(cardObject);
                        //Takes that card slot setting it to false to make sure it's not overwrited by another card
                        availableCardSlots[j] = false;
                        return;
                    }
                }
            }
        }
    }
        //Checks what sprite is in card
        public void CheckSlot()
    {
        for (int i = 0; deck.Count > 0; i++)
        {
            Debug.Log(cardObject.IconArray[i]);
        }
    }

}
