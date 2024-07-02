using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class ShowMeteoriteNumber : MonoBehaviour
    {
        public Text numberText;
        private AbsorbMeteorite AbsorbMeteorite;
        public GameObject earth;
        private void Start()
        {
            AbsorbMeteorite = earth.GetComponent<AbsorbMeteorite>();
        }
        private void Update()
        {
            numberText.text = AbsorbMeteorite.absorbMeteoriteNumber.ToString();
        }
    }
}

