using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JSONReadWriteSystem : MonoBehaviour
{
    private GameManager gManager;
    private void Start()
    {
        gManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }
    public void SaveScoreDataToJson()
    {
        ScoreData data = new ScoreData();
        data.playerName = "Tester1"; //placeholder
        data.score = gManager.score.ToString();
        data.level = SceneManager.GetActiveScene().name; 


    }
}
