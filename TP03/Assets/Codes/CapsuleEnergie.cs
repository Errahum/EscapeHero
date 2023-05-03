using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleEnergie : MonoBehaviour
{
    public HUD HUD;
    


    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            //print("capsule");
            Destroy(gameObject);
            HUD.EnergiesTotal += 100;
        }
    }


}
