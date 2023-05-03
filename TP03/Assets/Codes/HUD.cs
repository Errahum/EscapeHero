using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HUD : MonoBehaviour
{
    public int Minute;
    public float seconde;
    public Text Minutes;
    public Text Secondes;
    public Text Energies;
    public float EnergiesTotal;
    public Text Distances;
    public float DistancesTotal;
    public GameObject defaite;
    public GameObject Victoire;
    public float tempsEnergie;

    private void Start()
    {
        
    }
    void Update()
    {
        //Minuteur
        int i = 0;
        i += Minute -1;


        if (seconde >= 60)
        {
            Minute++;
            seconde -= 60;
            
        }
        

        if(Minute != 0 || seconde !> 0)
        {

            seconde -= Time.deltaTime;
           
            

            if (seconde < 1)
            {
                if (Minute != 0)
                {
                    Minute--;
                }
                if (Minute <= i)
                {
                    seconde += 59;
                    
                    
                    i--;
                }
                if (Minute != 0 && seconde != 0)
                {
                    seconde += 59;
                }

            }
        } //Minuteur Fin

        //-1 energie par seconde
        tempsEnergie += 1;
        tempsEnergie *= Time.deltaTime;
        EnergiesTotal -= tempsEnergie;




        //HUD
        Minutes.text = (Minute) + ":" + (seconde).ToString("n0");
        //Secondes.text = (seconde).ToString("n0");
        Energies.text = EnergiesTotal.ToString("n0");
        Distances.text = DistancesTotal.ToString("n2");

        //Défaite
        if ((EnergiesTotal <= 0) || (Minute == 0 && seconde <= 0))
        {
            defaite.SetActive(true);
        }
    }
}
