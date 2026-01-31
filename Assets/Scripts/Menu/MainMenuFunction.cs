using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Starting()
    {
        SceneManager.LoadScene(1);
        CollectCoin.ResetCoinCount();
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
        CollectCoin.ResetCoinCount();
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
