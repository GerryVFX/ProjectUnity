using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevels : MonoBehaviour
{
    [SerializeField] GameObject[] levels;
    
    void Start()
    {
        InvokeRepeating("CreateLevels", 10f, 13f);
    }

    public void CreateLevels()
    {
        Instantiate(levels[Random.Range(0, levels.Length)]);
    }
}
