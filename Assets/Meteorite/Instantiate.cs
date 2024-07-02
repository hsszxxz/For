using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class Instantiate : MonoBehaviour
    {
        public GameObject meteoritePre;
        private int number = 14;
        public float minX;
        public float maxX;
        public float minY;
        public float maxY;
        void Start()
        {
            for (int i = 0; i < number; i++) 
            {
                Vector3 randomPos = GetRandomPosition();
                Vector3 scale = new Vector3(1, 1, 1)* Random.Range(0.3f, 0.5f);
                Quaternion rotation =Quaternion.Euler(0f,0f,Random.Range(0f,360f));
                GameObject newObject =Instantiate(meteoritePre,randomPos,rotation);
                newObject.transform.localScale = scale; 
                newObject.transform.SetParent(this.transform);
                newObject.transform.tag = "meteorite";
            }
        }
        private Vector3 GetRandomPosition()
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            return new Vector3(randomX, randomY, 0);
        }
    }
}

