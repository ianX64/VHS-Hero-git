using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityClimb : MonoBehaviour
{

    private bool watchForPickup;
    EffectOnPick effect = new EffectOnPick();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerDataHolder>().ClimbWall = true;
            effect.PickAbility();
            Destroy(gameObject);

        }
    }

}
