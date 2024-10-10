using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 20f;

    [SerializeField]
    float Duration = 5f;
    [SerializeField]
    float elapsedTime = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0,0, moveSpeed * Time.deltaTime);
        elapsedTime += Time.deltaTime;

        if(elapsedTime>=Duration)
        {
            Destroy(gameObject);
        }
    }
}
