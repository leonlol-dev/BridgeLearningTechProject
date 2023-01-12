using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DoublePointsText : MonoBehaviour
{
    private TextMeshProUGUI text;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.text = "Double Points: " + gameManager.doubleScoreObject.name;
    }
}
