using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallDetection : MonoBehaviour
{
    [SerializeField] private PlayerCubeTrigger left;
    [SerializeField] private PlayerCubeTrigger right;
    [SerializeField] private PlayerCubeTrigger top;
    [SerializeField] private PlayerCubeTrigger bottom;

    public bool gameOver { get; private set; }
    private void Start()
    {
        gameOver = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(left.activated == true && right.activated == true && top.activated == true && bottom.activated == true)
        {
            gameOver = true;
            
        }
    }
}
