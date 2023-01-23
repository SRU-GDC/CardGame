using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;

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
    public bool Win = false;
    public int filpCount = 0;

    //Message Manger
    public GameObject MessagePanel;
    public TextMeshProUGUI MessageText;

    //Starts at the start of the project exctution
    //Runs DrawCard method to setup board
    private void Start()
    {
        MessagePanel.SetActive(false);
        for (setBoard = 0; setBoard < 9; setBoard++)
        {
            DrawCard();
        }
    }

    //Update's game per frame rate
    private void Update()
    {
        if(filpCount == 9)
        {
            CheckBoad();
        }
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
    /*//Checks what sprite is in card-Debugging
    public void CheckSlot()
    {
        if (cardObject.flipped)
        {
            Debug.Log(cardObject.spriteRenderer.sprite);
            //board[0] = cardObject.spriteRenderer.sprite;
        }
    }
    */

    //Returns values in the board-Debugging
    public void CheckBoad()
    {
        //Checking if any spots in the board are matches & Checking if there are no matches at all
        //Row 1: 0,1,2
        if (board[0] == 0 && board[1] == 0 && board[2] == 0)
        {
            WinGame();
        }
        else if(board[0] == 1 && board[1] == 1 && board[2] == 1)
        {
            WinGame();
        }
        else if (board[0] == 2 && board[1] == 2 && board[2] == 2)
        {
            WinGame();
        }
        //Row 2: 3,4,5
        else if (board[3] == 0 && board[4] == 0 && board[5] == 0)
        {
            Win = true;
            WinGame();
        }
        else if (board[3] == 1 && board[4] == 1 && board[5] == 1)
        {
            Win = true;
            WinGame();
        }
        else if (board[3] == 2 && board[4] == 2 && board[5] == 2)
        {
            Win = true;
            WinGame();
        }
        //Row 3: 6,7,8 
        else if (board[6] == 0 && board[7] == 0 && board[8] == 0)
        {
            Win = true;
            WinGame();
        }
        else if (board[6] == 1 && board[7] == 1 && board[8] == 1)
        {
            Win = true;
            WinGame();
        }
        else if (board[6] == 2 && board[7] == 2 && board[8] == 2)
        {
            Win = true;
            WinGame();
        }
        //Columns 1: 0,3,6
        else if (board[0] == 0 && board[3] == 0 && board[6] == 0)
        {
            Win = true;
            WinGame();
        }
        else if (board[0] == 1 && board[3] == 1 && board[6] == 1)
        {
            Win = true;
            WinGame();
        }
        else if (board[0] == 2 && board[3] == 2 && board[6] == 2)
        {
            Win = true;
            WinGame();
        }
        //Columns 2: 1,4,7
        else if (board[1] == 0 && board[4] == 0 && board[7] == 0)
        {
            Win = true;
            WinGame();
        }
        else if (board[1] == 1 && board[4] == 1 && board[7] == 1)
        {
            Win = true;
            WinGame();
        }
        else if (board[1] == 2 && board[4] == 2 && board[7] == 2)
        {
            Win = true;
            WinGame();
        }
        //Columns 3: 2,5,8
        else if (board[2] == 0 && board[5] == 0 && board[8] == 0)
        {
            Win = true;
            WinGame();
        }
        else if (board[2] == 1 && board[5] == 1 && board[8] == 1)
        {
            Win = true;
            WinGame();
        }
        else if (board[2] == 2 && board[5] == 2 && board[8] == 2)
        {
            Win = true;
            WinGame();
        }
        //Tells Player they Lost the Game and calls method
        else if (Win == false)
        {
            LoseGame();
        }

    }

    //Display's Loser Message and prompt to start new game
    public void LoseGame()
    {
        filpCount = 0;
        MessageText.text = "You Lose!";
        MessagePanel.SetActive(true);
    }
    //Display's Winner Message and prompt to go to menu
    public void WinGame()
    {
        filpCount = 0;
        MessageText.text = "YOU WON!";
        MessagePanel.SetActive(true);
    }
}