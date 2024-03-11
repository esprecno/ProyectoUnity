using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaController : MonoBehaviour
{
    public Sprite[] mySprites;
    private int index = 0;

    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(TurnCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    IEnumerator TurnCoRoutine()
    {
        yield return new WaitForSeconds(020f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if (index == 4)
        {
            index = 0;
        }
        StartCoroutine(TurnCoRoutine());
    }
}
