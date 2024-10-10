using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    // ������Ʈ�� ������ �� �ð�
    public float totalLifeDuration = 5f;

    // �ʱ� ����
    private Vector3 randomDirection;

    // ��� �ð� ����
    private float elapsedTime = 0f;

    void Start()
    {
        // X��� Z�࿡�� �ݰ� 3~5 ������ ���� ���� ����
        randomDirection = new Vector3(
            Random.Range(3f, 5f) * (Random.Range(0, 2) == 0 ? -1f : 1f), // X�� ����
            0f,  // Y���� 0
            Random.Range(3f, 5f) * (Random.Range(0, 2) == 0 ? -1f : 1f)  // Z�� ����
        ).normalized;
    }

    void Update()
    {
        // �� �����Ӹ��� �̵�
        transform.position += randomDirection * moveSpeed * Time.deltaTime;

        // ��� �ð� ����
        elapsedTime += Time.deltaTime;

        // ������ �ð��� ������ ������Ʈ �ı�
        if (elapsedTime >= totalLifeDuration)
        {
            Destroy(gameObject);
        }
    }
}
