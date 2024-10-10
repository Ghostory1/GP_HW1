using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltiMovement : MonoBehaviour
{
    Vector3 direction;   
    float speed;

    [SerializeField]
    float rotationSpeed = 720f;

    Vector3 rotationAxis; // 회전할 축

    [SerializeField]
    float Duration = 5f;
    [SerializeField]
    float elapsedTime = 0f;

    // 총알의 이동 방향과 속도를 설정하는 함수
    public void SetDirection(Vector3 shootDirection, float bulletSpeed)
    {
        direction = shootDirection;
        speed = bulletSpeed;
        elapsedTime = 0;
        // X, Y, Z축 중 무작위로 회전할 축을 설정 -> 회전축을 고정시켜야됌
        rotationAxis = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized; 
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        // 월드 좌표계를 기준으로 총알을 이동시킴 -> 회전값 영향 x
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // 일정한 회전 속도로 부드럽게 회전 -> 로컬 좌표계
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
        if(elapsedTime >= Duration)
        {
            Destroy(gameObject);
        }
    }
}
