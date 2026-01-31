using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    void OnTriggerEnter(Collider other) //coin must be trigger for player to collect , tick isTrigger box
    {
        coinFX.Play();
        CollectibleControl.coinCount+=1;
        this.gameObject.SetActive(false);
    }
    public static void ResetCoinCount()
    {
        CollectibleControl.coinCount = 0;
    }
}
