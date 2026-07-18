using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // プレイヤーの移動速度
    [SerializeField]
    private float moveSpeed = 5.0f;

    // ゲーム開始時に1回だけ実行される
    void Start()
    {

    }

    // 毎フレーム実行される
    void Update()
    {
        // 左右入力を取得
        // Aキー：-1
        // Dキー： 1
        float horizontal = Input.GetAxisRaw("Horizontal");

        // 前後入力を取得
        // Sキー：-1
        // Wキー： 1
        float vertical = Input.GetAxisRaw("Vertical");

        // 移動方向を作成
        // X = 左右
        // Y = 高さ（今回は動かさないので0）
        // Z = 前後
        Vector3 move = new Vector3(horizontal, 0.0f, vertical);

        // プレイヤーを移動させる
        // normalizedで斜め移動の速度を統一
        // moveSpeedで移動速度を調整
        // Time.deltaTimeでフレーム数による速度差をなくす
        transform.position += move.normalized * moveSpeed * Time.deltaTime;
    }
}