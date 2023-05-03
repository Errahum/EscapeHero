using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


/// <summary>
/// Classe qui d�place un rigidbody avec une Coroutine
/// 
/// Auteurs: Enseignants de 360-2PR-BB
/// </summary>
public class MouvementCoroutineTransform : MonoBehaviour
{
    //public GameObject unitychan;
    
    

    /// <summary>
    /// Le collider du plan sur lequel on se d�place
    /// </summary>
    [SerializeField] private Collider colliderPlan;  // Le plan pour d�tecter o� est le clic
    //les portes
    [SerializeField] private Collider colliderPlan2;
    [SerializeField] private Collider colliderPlan3;
    [SerializeField] private Collider colliderPlan4;
    [SerializeField] private Collider colliderPlan5;
    /// <summary>
    /// La vitesse de d�placement en unit� par seconde
    /// </summary>
    [SerializeField] private float vitesse;
    /// <summary>
    /// Coroutine pour le d�placement
    /// </summary>
    private Coroutine deplacement;
    public int Collisions = 0;


    void Start()
    {
        deplacement = StartCoroutine(Deplacer(transform.position));
    }


    void Update()
    {
        if (Collisions == 1)
        {
            StopCoroutine(deplacement);
        }





        if (Input.GetMouseButtonDown(0))
        {
            Vector3 positionClic;
            bool planClique = DeterminerClic(out positionClic, colliderPlan, colliderPlan2, colliderPlan3, colliderPlan4, colliderPlan5);
            if (planClique)
            {
                Vector3 nouvellePosition = new Vector3(positionClic.x, transform.position.y, positionClic.z);
                StopCoroutine(deplacement);
                deplacement = StartCoroutine(Deplacer(nouvellePosition));
            }
        }
    }
    /// <summary>
    /// Coroutine qui boucle tant que l'objet n'est pas sur la position cible
    /// </summary>
    /// <param name="positionCible">La position o� on se d�place</param>
    /// <returns>Un �num�rateur car c'est une Coroutine</returns>
    private IEnumerator Deplacer(Vector3 positionCible)
    {


        while (Vector3.Distance(transform.position, positionCible) >= vitesse * Time.deltaTime)
        {
            Vector3 direction = positionCible - transform.position;
            direction.Normalize();
            Vector3 pointDestination = transform.position + direction * vitesse * Time.deltaTime;
            transform.position = pointDestination;
            yield return new WaitForEndOfFrame();
        }
        transform.position = positionCible;
        yield return new WaitForEndOfFrame();
    }


    /**
     * M�thode qui v�rifie si le clic est sur le plan. Si le clic est � l'ext�rieur
     * alors, on retourne faux
     */
    private bool DeterminerClic(out Vector3 point, Collider zoneACliquer, Collider zoneACliquer2, Collider zoneACliquer3, Collider zoneACliquer4, Collider zoneACliquer5)
    {
        Vector3 positionSouris = Input.mousePosition;
        point = positionSouris;
        bool estClique = false;


        // Trouver le lien avec la cam�ra
        Ray ray = Camera.main.ScreenPointToRay(positionSouris);


        RaycastHit hit = new RaycastHit();


        if (Physics.Raycast(ray, out hit))
        {
            // V�rifier si l'objet touch� est le plan.
            if (hit.collider == (zoneACliquer  || zoneACliquer2 || zoneACliquer3 || zoneACliquer4 || zoneACliquer5))
            {
                point = hit.point;
                estClique = true;
            }
        }
        return estClique;
    }
    void OnTriggerEnter(Collider Col) //D�tecter les collisions si c'est dans le batiment du chateau. Cela permet de ne pas passer au travers de celui-ci.
    {
        if (Col.gameObject.tag == "Chateau")
        {
            print("collison = true");
            Collisions = 1;
        }
       

        var player = GameObject.Find("unitychan");
        var plane = GameObject.Find("Plane");
        plane.transform.position = player.transform.position;

    }

}