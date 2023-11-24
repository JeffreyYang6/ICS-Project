using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/TripleJumpBuff")]
public class TripleJumpBuff : PowerUp
{

    //Overriding the Apply method in order to make the player move faster
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().JumpRestrictions += 1;
    }
}
