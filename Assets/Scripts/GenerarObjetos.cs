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
        StartCoroutine(SpawnCoRoutine(0,0));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnCoRoutine(float waitTime, float pos)
    {
        yield return new WaitForSeconds(waitTime);
        transform.position = new Vector3(transform.position.x + pos, transform.position.y);
        Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)],transform.position, Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime),10f));
    }
}
