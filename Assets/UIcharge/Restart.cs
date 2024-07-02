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
    public class Restart : MonoBehaviour
    {
        private Button thisButton;
        private void Start()
        {
            thisButton = GetComponent<Button>();
            thisButton.onClick.AddListener(RestartGame);
        }
        private void RestartGame()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
            Time.timeScale = 1.0f;
        }
    }
}

