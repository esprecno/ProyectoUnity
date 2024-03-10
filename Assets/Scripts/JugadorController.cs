using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugadorController : MonoBehaviour
{
    public float playerJumpForce = 20f;
    public float playerSpeed = 5f;
    public Sprite[] mySprites;
    private int index = 0;

    private Rigidbody2D myRigidBody2D;
    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(WalkCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, playerJumpForce);
        }
        myRigidBody2D.velocity = new Vector2(playerSpeed, myRigidBody2D.velocity.y);
    }

    IEnumerator WalkCoRoutine() 
    {
        yield return new WaitForSeconds(0.05f);
        mySpriteRenderer.sprite = mySprites[index];
        if(index == 5)
        {
            index = 0;
        }
        StartCoroutine(WalkCoRoutine());
    }


}