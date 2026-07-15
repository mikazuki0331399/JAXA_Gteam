using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float rotateSpeed = 10000f;
    public float minSpeed = 3f;
    public float maxSpeed = 8f;

    public float destroyDistance = 50f;
    private float speed;

    private Vector3 startPosition;
    private Vector3 moveDirection;

    public void SetDirection(Vector3 dir)
    {
        moveDirection = dir.normalized;
    }

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);

        float size = Random.Range(0.5f, 2.0f);

        transform.localScale =
            Vector3.one * size;
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