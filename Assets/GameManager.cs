using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject capsule;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject barrel;
    public string scoreObjectText;
    public float scoreObjectChangeRate = 10.0f;
    public GameObject doubleScoreObject { get; set; }
    public int score { get; set; }
    

    private float timeToChangeObj;

    private void Start() {
        SetDoubleScoreObject();
    }
    
    private void FixedUpdate() 
    {
        if(Time.time >= timeToChangeObj)
        {
            timeToChangeObj = Time.time + 1f * (scoreObjectChangeRate);
            SetDoubleScoreObject();
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
