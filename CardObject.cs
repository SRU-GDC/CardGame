using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Allows a creation of a gameobject in Unity
//Default file name, and menu names, sub-menu of detailed cards using: menuName="Cards/Type"
[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardObject : ScriptableObject
{
    //Variables
    
    //Sets the name of the card
    public new string name;
    //Game Level speficfices what level the card will show on 
    public string category;
    //Background of the card, what it shown to the player before they select it
    public Sprite BG_Back;
    //Front of card, that will show when the play selects it, will be pulling from an array or list
    public Sprite Icon;
    //Hints to the player on where a matching set is, rare popups or unlock
    public string hints;
}
