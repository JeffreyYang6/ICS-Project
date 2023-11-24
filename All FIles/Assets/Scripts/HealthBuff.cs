using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerUp
{
    public float Amount = 3;

    //Overriding the Apply method in order to heal the player
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerHealth>().CurrentHealth += Amount;
        //target.GetComponent<SpriteRenderer>().color = Color.red;

    }
}
