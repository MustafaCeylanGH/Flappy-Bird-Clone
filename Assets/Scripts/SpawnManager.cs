using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject pipe;    
    private float yBoundary;
    private float xBoundary;
    private float repeatRate = 1.5f;
    private float time=0.5f;
    private float cancelInvokeTime = 5.0f;


    private void Start()
    {
        StartCoroutine(CancelInvokeNum());
        InvokeRepeating("SpawnPipe", time, repeatRate);
    }
    
    private Vector2 PipePosition()
    {
        yBoundary = Random.Range(-1, 2);
        xBoundary = Random.Range(5, 8);
        pipe.transform.position = new Vector2(xBoundary, yBoundary);
        return pipe.transform.position;
    }

    private void SpawnPipe()
    {       
        Instantiate(pipe, PipePosition(), Quaternion.identity);  
        
    }

    IEnumerator CancelInvokeNum()
    {
        yield return new WaitForSeconds(cancelInvokeTime);
        CancelInvoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipes"))
        {
            yBoundary = Random.Range(-1, 2);
            xBoundary = Random.Range(5, 8);
            collision.gameObject.transform.position = new Vector2(xBoundary, yBoundary);
        }
    }


}
