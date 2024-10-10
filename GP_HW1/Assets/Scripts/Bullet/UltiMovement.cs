using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltiMovement : MonoBehaviour
{
    Vector3 direction;   
    float speed;

    [SerializeField]
    float rotationSpeed = 720f;

    Vector3 rotationAxis; // ȸ���� ��

    [SerializeField]
    float Duration = 5f;
    [SerializeField]
    float elapsedTime = 0f;

    // �Ѿ��� �̵� ����� �ӵ��� �����ϴ� �Լ�
    public void SetDirection(Vector3 shootDirection, float bulletSpeed)
    {
        direction = shootDirection;
        speed = bulletSpeed;
        elapsedTime = 0;
        // X, Y, Z�� �� �������� ȸ���� ���� ���� -> ȸ������ �������Ѿ߉�
        rotationAxis = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized; 
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        // ���� ��ǥ�踦 �������� �Ѿ��� �̵���Ŵ -> ȸ���� ���� x
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // ������ ȸ�� �ӵ��� �ε巴�� ȸ�� -> ���� ��ǥ��
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
        if(elapsedTime >= Duration)
        {
            Destroy(gameObject);
        }
    }
}
