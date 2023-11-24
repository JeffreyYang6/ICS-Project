using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherent from build-in class ScriptableObject so that we are able to multiple instances of the Powerups
public abstract class PowerUp : ScriptableObject
{
    //Method that will be overridden and will do something to the player
    public abstract void Apply(GameObject player);
}
