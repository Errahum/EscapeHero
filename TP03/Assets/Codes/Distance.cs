using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    
    public Transform porte1;
    public Transform porte2;
    public Transform porte3;
    public Transform porte4;
    public Porte Porte;
    public HUD HUD;
    public float PorteEmplacement;
    public GameObject Player;


    void Update()
    {
        


        //la distance entre la porte et le joueur
        if (Porte.DoorNumber == 1)
        {
            float dist = Vector3.Distance(porte1.position, transform.position);
            PorteEmplacement = dist;
            //  print("Distance to other: " + dist);
            HUD.DistancesTotal = dist;

            if (Input.GetKeyUp(KeyCode.P))
            {
                Player.transform.position = porte1.position;

            }

        }
        if (Porte.DoorNumber == 2)
        {
            float dist = Vector3.Distance(porte2.position, transform.position);
            PorteEmplacement = dist;
            // print("Distance to other: " + dist);
            HUD.DistancesTotal = dist;

            if (Input.GetKeyUp(KeyCode.P))
            {
                Player.transform.position = porte2.position;

            }
        }
        if (Porte.DoorNumber == 3)
        {
            float dist = Vector3.Distance(porte3.position, transform.position);
            PorteEmplacement = dist;
            //print("Distance to other: " + dist);
            HUD.DistancesTotal = dist;

            if (Input.GetKeyUp(KeyCode.P))
            {
                Player.transform.position = porte3.position;

            }
        }
        if (Porte.DoorNumber == 4)
        {
            float dist = Vector3.Distance(porte4.position, transform.position);
            PorteEmplacement = dist;
            HUD.DistancesTotal = dist;
            //print("Distance to other: " + dist);

            if (Input.GetKeyUp(KeyCode.P))
            {
                Player.transform.position = porte4.position;

            }
        }
    }

    
}