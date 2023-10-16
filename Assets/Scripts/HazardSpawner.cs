using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
  
    public GameObject hazardPrefab;
    private float widthValue = 8;

    void Start()
    {
        InvokeRepeating("SpawnHazard", 1, 3);
        
    }

    private void SpawnHazard()
    {
        float randomXvalue = Random.Range(-widthValue, widthValue);
        float topYPosition = 10f; // Adjust this value as needed
        Vector3 pos = new Vector3(randomXvalue, topYPosition, 0);
        GameObject hazard = Instantiate(hazardPrefab, pos, Quaternion.identity);
        HazardMovement hazardMovement = hazard.GetComponent<HazardMovement>();
    }
   
}