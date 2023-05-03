using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porteCollisionVictoire : MonoBehaviour
{
    public HUD HUD;
    void OnTriggerEnter(Collider Col) //la collision de la porte pour avoir une victoire
    {
        if (Col.gameObject.tag == "Player")
        {
            print("victoire");
            HUD.Victoire.SetActive(true);
        }
    }
}
