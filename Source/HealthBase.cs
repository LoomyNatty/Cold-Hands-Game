using UnityEngine;
using System.Collections;

public class HealthBase : MonoBehaviour {
    //The current health of the character
    public int CurrentHealth;
    //The max amount of health the character can have
    public int MaxHealth;
    //The minimum amount of health the character can have
    public int MinHealth;
    //Modifier of the damage taken
    public int DamageModifier;
}
