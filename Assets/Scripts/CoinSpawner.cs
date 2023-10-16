using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coinPrefab;
    void Start()
    {
        Instantiate(coinPrefab, Vector3.zero, Quaternion.identity); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
