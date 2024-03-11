using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgilaController : MonoBehaviour
{

    public Sprite[] mySprites;
    private int index = 0;

    private SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(FlyCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FlyCoRoutine()
    {
        yield return new WaitForSeconds(0.20f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if (index == 4)
        {
            index = 0;
        }
        StartCoroutine(FlyCoRoutine());
    }
}
