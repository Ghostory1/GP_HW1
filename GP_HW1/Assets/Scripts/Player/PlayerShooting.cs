using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject Ultiprefab;
    [SerializeField]
    Transform shootPoint;
    [SerializeField]
    int BulletCount = 0;

    [SerializeField]
    private float bulletSpeed = 20f; // 총알 속도

    void Update()
    {
        if(BulletCount < 5)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clone = Instantiate(prefab);
                clone.transform.position = shootPoint.transform.position;
                clone.transform.rotation = shootPoint.transform.rotation;
                BulletCount++;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clone = Instantiate(Ultiprefab, shootPoint.position, Quaternion.identity);
                // 총알에 UltiMovement 스크립트 추가하여 이동 처리
                clone.AddComponent<UltiMovement>().SetDirection(shootPoint.forward, bulletSpeed);
                BulletCount = 0;
            }
        }
        
    }
}
