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
    private float bulletSpeed = 20f; // �Ѿ� �ӵ�

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
                // �Ѿ˿� UltiMovement ��ũ��Ʈ �߰��Ͽ� �̵� ó��
                clone.AddComponent<UltiMovement>().SetDirection(shootPoint.forward, bulletSpeed);
                BulletCount = 0;
            }
        }
        
    }
}
