using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class GameManger : MonoBehaviour
{
    //Reference to other Scripts
    CardObject cardObject;

    //Variables
    //Ui Text on cavnas
    public TextMeshProUGUI deckSizeCount;

    //List will contain all cards objects in the deck
    public List<CardObject> deck;
    //Array holds cardsSlots
    public Transform[] cardSlots;
    //Check how many slots can be filled/need filled
    public bool[] availableCardSlots;
    //Arrary board-Cards that are placed on the board
    public int[] board;
    public int boardsize = 0;
    public int setBoard;

    //Starts at the start of the project exctution
    //Runs DrawCard method to setup board
    private void Start()
    {
        for (setBoard = 0; setBoard < 9; setBoard++)
        {
            DrawCard();
        }
    }

    //Update's game per frame rate
    private void Update()
    {
        deckSizeCount.text = deck.Count.ToString();
    }

    //Method to Draw out cards and place them in any avilable Card Slot
    public void DrawCard()
    {

        //Check if any card objects are avaiable before placing cards on to the board
        if (deck.Count >= 1)
        {
            //Cycles through deck size and assigns slot
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
                        //Places that card in one of the card Slots avaiable
                        cardObject.transform.position = cardSlots[j].position;
                        cardObject.locatedinDeck = false;
                        //Takes that card slot setting it to false to make sure it's not overwrited by another card
                        availableCardSlots[j] = false;
                        //Assigns for a list of graphics to randomly to card
                        cardObject.iconArraryIndex = Random.Range(0, cardObject.IconArray.Length);
                        //Adds sprite Icon Index from card to array to the board array
                        board[boardsize] = cardObject.iconArraryIndex;
                        //Move to next element in array to store iconIndex
                        boardsize++;
                        //Removes cardObject from deck to move to next card
                        deck.Remove(cardObject);
                        return;
                    }
                }
            }
        }
    }
    //Checks what sprite is in card-Debugging
    public void CheckSlot()
    {
        if (cardObject.flipped)
        {
            Debug.Log(cardObject.spriteRenderer.sprite);
            //board[0] = cardObject.spriteRenderer.sprite;
        }
        else
        {
            Debug.Log("Flip Cards to see what's under them.");
        }
    }
    
    //Returns values in the board-Debugging
    public void CheckBoad()
    {
        for (int i = 0; i <board.Length; i++)
        {
            Debug.Log(board[i]);
        }
    }

    //Checking if any spots in the board are matches & Checking if there are no matches at all
    //Row 1: 0,1,2 Row 2: 3,4,5 Row 3: 6,7,8 
    //Columns 1: 0,3,6 Columns 2: 1,4,7 Columns 3: 2,5,8

}