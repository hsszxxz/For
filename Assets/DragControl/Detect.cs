using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class Detect : MonoBehaviour
    {
        public float WinX;
        public GameObject defeatCanvas;
        public GameObject winCanvas;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("planets"))
            {
                Time.timeScale = 0f;
                defeatCanvas.SetActive(true);
            }
        }
        private bool IsWin()
        {
            if(this.transform.position.x >= WinX)
            {
                return false;
            }
            else { return true; }
        }
        private void Update()
        {
            if (IsWin())
            {
                Time.timeScale = 0f;
                winCanvas.SetActive(true);
            }
        }
    }
}

