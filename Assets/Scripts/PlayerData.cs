using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string playerName { get; private set; }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    

}
