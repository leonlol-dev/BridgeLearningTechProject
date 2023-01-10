using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private Transform playerSpawn;

    private GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Score")
        {
            // Checks if the name of the Game Object is the same as the double objects name plus clone because instantiated objects have clone added.
            if(other.transform.gameObject.name == gameManager.doubleScoreObject.name + "(Clone)")
            {
                Debug.Log("Double Score!");
                gameManager.score +=1;
            }
            gameManager.score += 1;
            Destroy(other.gameObject, 2f);
        }

        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = playerSpawn.position;
        }
    }
}
