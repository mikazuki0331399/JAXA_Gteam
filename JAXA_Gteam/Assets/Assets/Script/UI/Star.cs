using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 50f;

    // 星を動かすかどうか
    public bool canMove = false;

    void Update()
    {
        // カウントダウン中は停止
        if (!canMove)
        {
            return;
        }

        // 星を下へ移動
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // 画面外に出たら上へ戻す
        if (transform.localPosition.y < -600)
        {
            Vector3 pos = transform.localPosition;
            pos.y = 600;
            transform.localPosition = pos;
        }
    }
}