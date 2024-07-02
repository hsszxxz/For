using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class ContinueGame : MonoBehaviour
    {
        private Button continueGameButton;
        public GameObject currentCanvas;
        public GameObject targetCanvas;
        private void Start ()
        {
            continueGameButton = GetComponent<Button>();
            continueGameButton.onClick.AddListener(Continue);
        }
        private void Continue()
        {
            Time.timeScale = 1.0f;
            currentCanvas.SetActive(false);
            targetCanvas.SetActive(true);
        }
    }
}

