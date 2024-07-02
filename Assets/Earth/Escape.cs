using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class Escape : MonoBehaviour
    {
        private Control controlScript;
        private float closestDistance;
        private Rigidbody2D earthRigidbody2D;
        private Vector3 direction;
        private AbsorbMeteorite absorbMeteoriteScript;
        public Sprite[] earthSprite;
        private SpriteRenderer thisRenderer;
        private void Start()
        {
            earthRigidbody2D = GetComponent<Rigidbody2D>();
            absorbMeteoriteScript = GetComponent<AbsorbMeteorite>();
            thisRenderer = GetComponent<SpriteRenderer>();
        }
        private void Update()
        {
            if (absorbMeteoriteScript.absorbMeteoriteNumber >= 5 && Input.GetKeyDown(KeyCode.Space))
            {
                EarthEscape(earthRigidbody2D);
                thisRenderer.sprite = earthSprite[1];
                absorbMeteoriteScript.absorbMeteoriteNumber -=5;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                thisRenderer.sprite = earthSprite[0];
            }
        }
        public void EarthEscape( Rigidbody2D earthRigidbody2D)
        {
            Transform closestPlanet = GetClosestPlanet(out closestDistance).transform;
            controlScript = closestPlanet.GetComponent<Control>();
            direction = (closestPlanet.position-transform.position).normalized;
            if (!(closestDistance >= controlScript.planetRadius[2]))
            {
                int forceIndex = controlScript.DistanceCharge(closestDistance);
                earthRigidbody2D.AddForce(-direction * 20f * controlScript.planetForce[forceIndex], ForceMode2D.Impulse);
            }
        }

        private GameObject GetClosestPlanet(out float closestDistance)
        {
            GameObject[] planets = GameObject.FindGameObjectsWithTag("planets");
            GameObject closestObject = null;
            closestDistance = Mathf.Infinity;
            foreach (GameObject planet in planets)
            {
                float distance = Vector3.Distance(transform.position, planet.transform.position);
                if (distance < closestDistance)
                {
                    closestObject = planet;
                    closestDistance = distance-1.3f;
                }
            }
            return closestObject;
        }
    }
}

