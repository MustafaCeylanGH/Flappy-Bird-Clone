using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    [SerializeField] private float pipesSpeed;
    private void Update()
    {
        MovePipes();
    }
    private void MovePipes()
    {
        transform.Translate(-pipesSpeed * Time.deltaTime, 0, 0);
    }
}
