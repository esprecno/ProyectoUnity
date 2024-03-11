using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataObjetosController : MonoBehaviour
{
    public Transform targetPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetPlayer.position.x - 17f, 0, -10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
