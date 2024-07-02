using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class PlanetsChose : MonoBehaviour
    {
        public Transform chosenPlanet;
        private PlanetsMove planetsMoveScript;
        private void Update()
        {
            chosenPlanet=GetHitTransform();
            if (chosenPlanet != null ) 
            {
                chosenPlanet.GetComponent<SpriteRenderer>().color = Color.red;
                planetsMoveScript = chosenPlanet.GetComponent<PlanetsMove>();
                if( Input.GetMouseButtonDown(0) )
                {
                    GameObject[] planetsGameObject = GameObject.FindGameObjectsWithTag("planets");
                    foreach( GameObject planet in planetsGameObject ) 
                    {
                        planet.GetComponent<PlanetsMove>().enabled = false;
                    }
                    planetsMoveScript.enabled=true;
                }
            }
            else
            {
                GameObject[] planetsGameObject = GameObject.FindGameObjectsWithTag("planets");
                foreach (GameObject planet in planetsGameObject)
                {
                    planet.GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }

        private Transform GetHitTransform()
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit =Physics2D.Raycast(mousePos,Vector2.zero);
            if (hit.collider != null && hit.transform.CompareTag("planets"))
            {
                Transform hitTransform = hit.transform;
                return hitTransform;
            }
            else
            {
                return null;
            }
            
        }
    }
}

