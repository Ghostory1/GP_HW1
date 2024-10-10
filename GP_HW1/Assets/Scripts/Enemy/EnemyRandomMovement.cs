using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    // 오브젝트가 유지될 총 시간
    public float totalLifeDuration = 5f;

    // 초기 방향
    private Vector3 randomDirection;

    // 경과 시간 추적
    private float elapsedTime = 0f;

    void Start()
    {
        // X축과 Z축에서 반경 3~5 사이의 랜덤 방향 설정
        randomDirection = new Vector3(
            Random.Range(3f, 5f) * (Random.Range(0, 2) == 0 ? -1f : 1f), // X축 방향
            0f,  // Y축은 0
            Random.Range(3f, 5f) * (Random.Range(0, 2) == 0 ? -1f : 1f)  // Z축 방향
        ).normalized;
    }

    void Update()
    {
        // 매 프레임마다 이동
        transform.position += randomDirection * moveSpeed * Time.deltaTime;

        // 경과 시간 누적
        elapsedTime += Time.deltaTime;

        // 설정된 시간이 지나면 오브젝트 파괴
        if (elapsedTime >= totalLifeDuration)
        {
            Destroy(gameObject);
        }
    }
}
