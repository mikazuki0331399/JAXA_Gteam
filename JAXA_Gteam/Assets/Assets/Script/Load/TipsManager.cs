using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TipsManager : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI messageText;

    public TipData[] tips;

    void Start()
    {
        int index = Random.Range(0, tips.Length);

        titleText.text = tips[index].title;
        titleText.color = tips[index].titleColor;

        messageText.text = tips[index].message;
    }
}