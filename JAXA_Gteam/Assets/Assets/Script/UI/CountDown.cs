using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public TextMeshProUGUI countdownText;
    public GameManager gameManager;
    public EnemySpawner enemySpawner;
    public ProgressController progressController;
    public PlayerMove playerMove;
    IEnumerator Start()
    {
        countdownText.text = "  3";
        yield return new WaitForSeconds(1);

        countdownText.text = "  2";
        yield return new WaitForSeconds(1);

        countdownText.text = "  1";
        yield return new WaitForSeconds(1);

        countdownText.text = "START!";
        yield return new WaitForSeconds(1);
     
        countdownText.gameObject.SetActive(false);

        playerMove.canMove = true;
        Debug.Log("プレイヤー移動開始");
        enemySpawner.StartGame();
        gameManager.gameStarted = true;
        progressController.gameStarted = true;
    }

}
