using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


//Allows a creation of a gameobject in Unity
//Default file name, and menu names, sub-menu of detailed cards using: menuName="Cards/Type"
//[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardObject : MonoBehaviour
{
    public bool locatedinDeck;
    public int handIndex;

    //Reference to other Scripts
    GameManger gm;

    //Variables 
    //Sets the name of the card
    public new string name;
    //Game Level speficfices what level the card will show on 
    public string category;
    //Background of the card, what it shown to the player before they select it
    public Sprite BG_Back;
    //Front of card, that will show when the play selects it, will be pulling from an array
    public Sprite[] IconArray;
    //Index measurement of array
    public int arrayIndex;
    //Hints to the player on where a matching set is, rare popups or unlock
    public string hints;
    //Reference to Sprite render
    public SpriteRenderer spriteRenderer;


    //Count on how many times card is clicked
    int pressed = 0;

    //Starts at the start of the project exctution
    private void Start()
    {
        //Find Object types of refernce in gameManger
        gm = FindObjectOfType<GameManger>();
        //Sets the spriteRender and referencing to gameobject and inspector
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //Sets card image from start-Card Background
        spriteRenderer.sprite = BG_Back;
    }

    //Calls this method whenever a card is pressed
    public void OnMouseDown()
    {
        if (pressed == 3)
        {
            //Calls the Change Sprite Method
            ChangeSprite();
        }
        else
        {
            pressed++;
            Debug.Log("Card was pressed: " + pressed + " Times, click a card three times to see something happen.");
        }
            
    }

    /*private void OnMouseDown()
    {
        
        if (!locatedinDeck)
        {
            //Postions card onto card slot
            Instantiate(BG_Back, transform.position, Quaternion.identity);
            locatedinDeck = true;
            gm.availableCardSlots[handIndex] = true;
            
        }
    }*/

    //Changes the sprite design on the card
    public void ChangeSprite()
    {
        arrayIndex = Random.Range(0, IconArray.Length);
        spriteRenderer.sprite = IconArray[arrayIndex];
    }

}
