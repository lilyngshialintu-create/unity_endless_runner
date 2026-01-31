using UnityEngine; 
using System.Collections; 
 
public class NPC : MonoBehaviour 
{ 
    public GameObject storyPlotObject; 
    public GameObject instructionPanel; 
    
 
    IEnumerator OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("Player")) 
        { 
            storyPlotObject.SetActive(true); 
            // Wait for 3 seconds 
            yield return new WaitForSeconds(7); 
            // Hide the story plot after 7 seconds 
            storyPlotObject.SetActive(false); 
            instructionPanel.SetActive(true); 
            yield return new WaitForSeconds(3); 
            instructionPanel.SetActive(false); 
        
             
 
 
        } 
    } 
}