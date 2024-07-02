using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class BackToTable : MonoBehaviour
    {
        private Button quitGame;
        private void Start()
        {
            quitGame = GetComponent<Button>();
            quitGame.onClick.AddListener(QuitGame);
        }
        private void QuitGame()
        {
            Application.Quit();
        }
    }
}

