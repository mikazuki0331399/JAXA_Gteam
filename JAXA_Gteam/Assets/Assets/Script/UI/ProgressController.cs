using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour
{
    public RectTransform arrow;

    public float gameTime = 60f;

    private float timer = 0f;

    public float startY = 200f;
    public float endY = 250f;
    public float offsetX = 0f;
    void Update()
    {
        timer += Time.deltaTime;

        float progress = timer / gameTime;

        progress = Mathf.Clamp01(progress);

        float y = Mathf.Lerp(
            startY,
            endY,
            progress
        );


        arrow.anchoredPosition =
            new Vector2(
                offsetX,
                y
            );

    }
}

