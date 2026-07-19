using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI finishText;

    public float gameTime = 60f;

    private float timer;

    private bool isFinished = false;

    void Update()
    {
        if (isFinished) return;

        timer += Time.deltaTime;

        if (timer >= gameTime)
        {
            FinishGame();
        }
    }

    public void FinishGame()
    {
        if (isFinished) return;

        isFinished = true;
        Debug.Log("FinishåƒÇ—èoÇµ");
        finishText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }
}
