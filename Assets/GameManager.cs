using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum type
    {
        Barrel,
        Capsule,
        Sphere,
        Cube
    }
    public type scoreObject;
    public GameObject doubleScoreObject { get; set; }
    public int score { get; set; }

    public void DoubleScoreObject()
    {
        int chance = Random.Range(1, 4);
        switch (chance)
        {
            case 1:

                break;

            case 2:

                break;

            case 3:
              
                break;

            case 4:

                break;
        }
    }

    public void CheckDoubleScore(GameObject spawnObject)
    {
        if(spawnObject.gameObject.name == doubleScoreObject.gameObject.name)
        {
            score += 1;
        }
    }

}
