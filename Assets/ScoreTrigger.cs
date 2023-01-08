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
            gameManager.score += 1;
            Destroy(other.gameObject, 2f);
        }

        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = playerSpawn.position;
        }
    }
}
