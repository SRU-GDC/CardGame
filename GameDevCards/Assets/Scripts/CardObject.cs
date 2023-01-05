using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


//Allows a creation of a gameobject in Unity
//Default file name, and menu names, sub-menu of detailed cards using: menuName="Cards/Type"
//[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardObject : MonoBehaviour
{
    //Checks if card is in the deck to pull from
    public bool locatedinDeck;
    //Card location in hand of slots
    public int handIndex;

    //Reference to other Scripts
    GameManger gm;

    //Variables 
    //Sets the name of the card
    public new string name;
    //Game Level speficfices what level the card will show on 
    public string category;
    //Front of card, that will show when the play selects it, will be pulling from an array
    public Sprite[] IconArray;
    //Index value of IconArray
    public int iconArraryIndex;
    //Hints to the player on where a matching set is, rare popups or unlock
    public string hints;
    //Reference to Sprite render
    public SpriteRenderer spriteRenderer;
    //Variable to check if card is flipped
    public bool flipped;

    //Starts at the start of the project exctution
    private void Start()
    {
        //Find Object types of refernce in gameManger
        gm = FindObjectOfType<GameManger>();
        //Sets the spriteRender and referencing to gameobject and inspector
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    //Calls this method whenever a card is pressed
    public void OnMouseDown()
    {
        if (flipped == false)
        {
            //Calls the Change Sprite Method
            ChangeSprite();
        }
    }

    //Changes the sprite design on the card
    public void ChangeSprite()
    {
        //Checks if card is flipped to show graphic
        flipped = true;
        //Takes theat choosen graphic and changes card image
        spriteRenderer.sprite = IconArray[iconArraryIndex];
    }

}
