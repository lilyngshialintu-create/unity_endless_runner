using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5; // need to include public to see in inspector view
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;
  
    // Update is called once per frame, void start is only for stuff that happens one time so its deleted
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);//"translate" = changing, vector3 for 3d, character moves forward, deltaTime(move forward relative to game time)
        if(canMove ==true){
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))//tells what the object do when u press "A" key OR u press leftarrow
           {
                if(this.gameObject.transform.position.x > LevelBoundary.leftSide)
                { 
                    transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed);
                }
           }
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))//tells what the object do when u press "A" key OR u press leftarrow
           {
                if(this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed*-1);
                }
        
           }
            if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }
        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up*Time.deltaTime*3, Space.World); //Space.World is needed to do it relative to world around player
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up*Time.deltaTime*-3, Space.World); //Space.World is needed to do it relative to world around player
            }
        }
        
    } //moveSpeed to tell it how fast to go, Space.World (movement is relative to world we're creating)
    IEnumerator JumpSequence()
    {
        float initialHeight = transform.position.y;
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
        transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);

    }
}
