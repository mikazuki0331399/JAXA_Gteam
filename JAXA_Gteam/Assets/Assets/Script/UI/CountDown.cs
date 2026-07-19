using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public TextMeshProUGUI countdownText;

    public EnemySpawner enemySpawner;
    public ProgressController progressController;

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

        enemySpawner.StartGame();

        progressController.gameStarted = true;
    }

}
