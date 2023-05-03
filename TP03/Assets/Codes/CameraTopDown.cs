using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class CameraTopDown : MonoBehaviour

{


    [SerializeField] private GameObject joueur;

    [SerializeField] private float hauteur = 2;
    public HUD HUD;


    // Start is called before the first frame update

    void Start()

    {

        PlacerCamera();


    }


    // Update is called once per frame

    void Update()

    {
        //Mouvement de la caméra
        if (Input.GetKey(KeyCode.PageUp) && (HUD.EnergiesTotal > 0f))
        {
            if (hauteur <= 18)
            {
                hauteur += 0.005f;
            }
                
                HUD.tempsEnergie += 10; 
        }
        else
        {
            if(hauteur != 12)
            {
                hauteur -= 0.005f;
            }
        }//Mouvement de la caméra Fin

        PlacerCamera();


    }


    void PlacerCamera()

    {

        float x = joueur.transform.position.x;

        float z = joueur.transform.position.z;

        transform.localPosition = new Vector3(x, hauteur, z);


    }

}