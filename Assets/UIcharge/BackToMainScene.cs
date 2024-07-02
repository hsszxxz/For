using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class BackToMainScene : MonoBehaviour
    {
        private Button startButton;
        private void Start()
        {
            startButton = GetComponent<Button>();
            startButton.onClick.AddListener(StartThisGame);
        }
        public void StartThisGame()
        {
            SceneManager.LoadScene("StartScene");
        }

    }
}

