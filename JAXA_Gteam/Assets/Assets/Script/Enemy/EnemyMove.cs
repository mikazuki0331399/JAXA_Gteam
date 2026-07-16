using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float rotateSpeed = 10000f;
    

    public float destroyDistance = 50f;
    public float speed;

    private Vector3 startPosition;
    private Vector3 moveDirection;

    public void SetDirection(Vector3 dir)
    {
        moveDirection = dir.normalized;
    }

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position +=
            moveDirection * speed * Time.deltaTime;

        transform.Rotate(
            0,
            rotateSpeed * Time.deltaTime,
            0
        );

        float distance =
                   Vector3.Distance(
                       startPosition,
                       transform.position
                   );

        if (distance >= destroyDistance)
        {
            Destroy(gameObject);
        }

    }
}