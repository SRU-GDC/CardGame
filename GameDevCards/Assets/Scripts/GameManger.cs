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
    //Row & Column size
    const int ROWS = 3;
    const int COLS = 3;

    
    //List will contain all cards in the deck
    public List<CardObject> deck;
    //Array holds cardsSlots
    public Transform[] cardSlots;
    //Check how many slots can be filled/need filled
    public bool[] availableCardSlots;

    //Method to Draw out cards and place them in any avilable Card Slot
    public void DrawCard()
    {
        //Check if any cards exitist before adding in a random card
        if(deck.Count >= 1)
        {
            CardObject randCard = deck[Random.Range(0, deck.Count)];
            //Loop through to check how many slots are available
            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    //Grabs the given random card
                    randCard.gameObject.SetActive(true);
                    randCard.handIndex = i;
                    //Places that card in one of the card Slots avaiable
                    randCard.transform.position = cardSlots[i].position;
                    randCard.locatedinDeck = false;
                    deck.Remove(randCard);
                    //Takes that card slot setting it to false to make sure it's not overwrited by another card
                    availableCardSlots[i] = false;
                    return;
                }
            }
        }
    }

    //Checks what sprite is in card
    public void CheckRow()
    {
        for (int i = 0; i < availableCardSlots.Length; i++)
        {
            Debug.Log("Card located at: " + cardSlots[i] + "Has " + cardObject.spriteRenderer.sprite + " Sprite");
        }
    }

    //Update's game per frame rate
    private void Update()
    {
        deckSizeCount.text = deck.Count.ToString();
    }


}
