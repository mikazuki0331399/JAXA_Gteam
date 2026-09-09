using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 500f;

    [SerializeField]
    private float minY = -330f;

    [SerializeField]
    private float maxY = 330f;

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 pos = transform.localPosition;

        pos.y += vertical * moveSpeed * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.localPosition = pos;
    }
}