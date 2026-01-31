using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
   
    void Update()
    {
        coinCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" +coinCount; //"" bc engine is expecting to read text , need it to display number
        coinEndDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" +coinCount;
    }
}
