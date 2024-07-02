using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class AbsorbMeteorite : MonoBehaviour
    {
        public int absorbMeteoriteNumber = 0;
        private Rigidbody2D earthRigidbody2D;
        public AudioClip soundEffect;
        private AudioSource audioSource;
        void Start ()
        {
            earthRigidbody2D = GetComponent<Rigidbody2D>();
            audioSource = GetComponent<AudioSource>();
            audioSource.clip =soundEffect;
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("meteorite"))
            {
                Destroy(other.gameObject);
                transform.localScale*=1.03f;
                earthRigidbody2D.mass *= 1.02f;
                absorbMeteoriteNumber+=1;
                audioSource.Play();
            }
        }
    }
}

