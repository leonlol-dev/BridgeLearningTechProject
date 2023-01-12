using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    [SerializeField] private GameObject[] walls;

    //Public 
    public float spawnRate = 0.5f;
    //Private
    private int index = 0;
    private float nextTimeToActivate;

    private void Start()
    {
        nextTimeToActivate = spawnRate;
        Shuffle(walls);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time >= nextTimeToActivate)
        {
            nextTimeToActivate = Time.time + 1f / (spawnRate);
            walls[index].SetActive(true);
            if (index < walls.Length-1)
            {
                index++;
            }
        }
    }

    private void Shuffle(GameObject[] a)
    {
        // Loops through array
        for (int i = a.Length - 1; i > 0; i--)
        {
            // Randomize a number between 0 and i (so that the range decreases each time)
            int rnd = Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overright when we swap the values
            GameObject temp = a[i];

            // Swap the new and old values
            a[i] = a[rnd];
            a[rnd] = temp;
        }
    }
}
