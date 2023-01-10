using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeTrigger : MonoBehaviour
{
    public bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            activated = true;
        }
    }

    private void OnTriggerStay(Collider other) 
    {

        if(other.gameObject.tag == "Wall")
        {
            activated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            activated = false;
        }
    }
} 