using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triche : MonoBehaviour
{
    public HUD HUD;
    public Distance Distance;
    public GameObject Player;

    
    void Update()
    {
        

        if (Input.GetKeyUp(KeyCode.L))
        {
            HUD.EnergiesTotal = 10;
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            
            HUD.Minute -= HUD.Minute;
            HUD.seconde = 10;
        }
    }
}
