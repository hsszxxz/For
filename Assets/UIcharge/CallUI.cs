using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class CallUI : MonoBehaviour
    {
        public GameObject UICanvas;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                UICanvas.SetActive(true);
            }
        }
    }
}

