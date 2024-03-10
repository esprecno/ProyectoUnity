using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObjetos : MonoBehaviour
{
    public GameObject[] itemPrefab;

    public float minTime = 1f;
    public float maxTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCoRoutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)], new Vector3(transform.position.x +3f, transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime)));
    }
}
