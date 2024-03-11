using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaController : MonoBehaviour
{
    public float bulletSpeed = 10f;

    public GameManager myGameManager;

    private Rigidbody2D myRigidBody2D;
    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody2D.velocity = new Vector2(bulletSpeed, myRigidBody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemBueno"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("ItemMalo"))
        {
            myGameManager.AddScore();
            Destroy(collision.gameObject);
        }
    }
}
