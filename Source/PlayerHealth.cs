using UnityEngine;
using System.Collections;

public class PlayerHealth : HealthBase {
    //Whether the player has a shield
    public bool bHasSheild;

    public int SheildMod;

    void TakeDamage(int Dam)
    {
        if(bHasSheild)
        {
            //If there isn't enough shield to absorb the hit
            if(SheildMod - Dam < 0 )
            {
                //Remove the amount of damage needed to break the shield
                Dam -= SheildMod;
                //Remove the shield
                SheildMod = 0;
                //Remove the remainder from the health
                CurrentHealth -= Dam;
                bHasSheild = false;
            }
            else
            {
                SheildMod -= Dam;
            }
        }
        else
        {
            CurrentHealth -= Dam;
        }
    }

    public void PickupSheild(int modifier)
    {
        //If the player already has a shield
        if(bHasSheild)
        {
            return;
        }
        else
        {
            SheildMod = modifier;
            bHasSheild = true;
        }
    }
}