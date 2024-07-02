using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class GameRuleButton : MonoBehaviour
    {
        private Button thisButton;
        public GameObject thisCanvas;
        public GameObject ruleCanvas;
        private void Start()
        {
            thisButton = GetComponent<Button>();
            thisButton.onClick.AddListener(CallRule);    
        }
        private void CallRule()
        {
            Time.timeScale = 0f;
            thisCanvas.SetActive(false);
            ruleCanvas.SetActive(true);
        }
    }
}

