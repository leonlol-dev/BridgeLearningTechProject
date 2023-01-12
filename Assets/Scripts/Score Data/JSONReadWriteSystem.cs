using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JSONReadWriteSystem : MonoBehaviour
{
  
    public void SaveScoreDataToJson(string name, int score)
    {
        ScoreData data = new ScoreData();
        data.playerName = name; //placeholder
        data.score = score.ToString();
        data.level = SceneManager.GetActiveScene().name; 

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/PlayerScore.json", json);


    }
}
