using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Allows a creation of a gameobject in Unity
//Default file name, and menu names, sub-menu of detailed cards using: menuName="Cards/Type"
[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardObject : ScriptableObject
{
    //Variables
    public new string name;
    //Game Level
    public string category;
    //Art Work
    public Sprite artwork;

    public string hints;
}
