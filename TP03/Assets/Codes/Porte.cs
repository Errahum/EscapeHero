using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public GameObject porte1;
    public GameObject porte2;
    public GameObject porte3;
    public GameObject porte4;
    public HUD HUD;
    public int randomDoor;
    public int DoorNumber;


    // Start is called before the first frame update
    void Start()
    {
        //Positionnement d'une porte alléatoirement
        randomDoor = Random.Range(1, 5);
        DoorNumber = DoorNumber + randomDoor;

        print(("The door is the number ") + (randomDoor));
       // print(("test ") + (DoorNumber));

        if (randomDoor == 1)
        {
            porte1.SetActive(true);
        }
        if (randomDoor == 2)
        {
            porte2.SetActive(true);
        }
        if (randomDoor == 3)
        {
            porte3.SetActive(true);
        }
        if (randomDoor == 4)
        {
            porte4.SetActive(true);
        }
    }
    


}
