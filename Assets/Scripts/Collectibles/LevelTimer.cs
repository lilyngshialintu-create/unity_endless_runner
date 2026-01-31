using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public GameObject Timer;
    public GameObject EndTimer;
    public int disTime;
    public bool addingTime = false;
    public float timeDelay =1f;

    void Update()
    {
        if (addingTime == false)
        {
            addingTime = true;
            StartCoroutine(AddingTime());
        }
    }
    IEnumerator AddingTime()
    {
        disTime += 1;
        Timer.GetComponent<TMPro.TextMeshProUGUI>().text ="" +disTime;
        EndTimer.GetComponent<TMPro.TextMeshProUGUI>().text ="" +disTime;
        yield return new WaitForSeconds(timeDelay);
        addingTime = false;
    }
}
