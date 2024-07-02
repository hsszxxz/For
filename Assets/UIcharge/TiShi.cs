using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class TiShi : MonoBehaviour
    {
        private Button tiShiButton;
        public GameObject currentCanvas;
        public GameObject tiShiCanvas;
        private void Start ()
        {
            tiShiButton = GetComponent<Button>();
            tiShiButton.onClick.AddListener(GoToTiShi);
        }
        private void GoToTiShi()
        {
            currentCanvas.SetActive(false);
            tiShiCanvas.SetActive(true);
        }
    }
}

