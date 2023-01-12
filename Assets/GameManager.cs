using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Object Spawner")]
    [SerializeField] private SpawnObject objectSpawner;
    [Space(20)]
    [Header("Wall Spawner")]
    [SerializeField] private WallScript wallSpawner;
    [Space(20)]
    [Header("Game Over Condition")]
    [SerializeField] private PlayerWallDetection wallDetection;
    [Space(10)]
    [Header("Game Over UI")]
    [SerializeField] private GameObject gameOverManager;
    [Space(20)]

    
    [Header("Prefabs to set")]
    [SerializeField] private GameObject capsule;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject barrel;
    [Space(20)]
    [Header("Variables")]
    public float scoreObjectChangeRate = 10.0f;
    public float objectSpawnRate = 1f;
    public float wallSpawnRate = 0.66f;
    private JSONReadWriteSystem jsonSystem;

    //Getters/setters
    public GameObject doubleScoreObject { get; set; }
    public int score { get; set; }

    //private
    private string scoreObjectText = "error";
    private float timeToChangeObj;
    private bool alreadySet = false;

    private void Start() {
        jsonSystem = GetComponent<JSONReadWriteSystem>();
        objectSpawner.spawnRate = objectSpawnRate;
        wallSpawner.spawnRate = wallSpawnRate;
        SetDoubleScoreObject();
    }
    
    private void FixedUpdate() 
    {
        if(Time.time >= timeToChangeObj)
        {
            timeToChangeObj = Time.time + 1f * (scoreObjectChangeRate);
            SetDoubleScoreObject();
        }

        //Game Over
        if(wallDetection.gameOver == true)
        {
            Debug.Log("game over");
            gameOverManager.SetActive(true);
            if(alreadySet == false)
            {
                alreadySet = true;
                gameOverManager.GetComponent<GameOverManager>().scoreText.text = "Your score was: " + score;
                jsonSystem.SaveScoreDataToJson("tester1", score);
                
            }
            
        }

        if(score == 100)
        {
            gameOverManager.SetActive(true);
            gameOverManager.GetComponent<GameOverManager>().gameStateText.text = "YOU WIN!";
            gameOverManager.GetComponent<GameOverManager>().scoreText.text = "Your score was: " + score;
            jsonSystem.SaveScoreDataToJson("tester1", score);
        }
    }

    //Sets the new object for double score.
    public void SetDoubleScoreObject()
    {
        int chance = Random.Range(1, 4);
        switch (chance)
        {
            case 1:
                doubleScoreObject = barrel;
                scoreObjectText = "Barrel";
                break;
            case 2:
                doubleScoreObject = capsule;
                scoreObjectText = "Capsule";
                break;
            case 3:
                doubleScoreObject = sphere;
                scoreObjectText = "Sphere";
                break;
            case 4:
                doubleScoreObject = cube;
                scoreObjectText = "Cube";
                break;
        }
    }

}
