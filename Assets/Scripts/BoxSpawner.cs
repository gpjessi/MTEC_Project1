using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject boxPrefab;
    private float widthValue = 8;

    void Start()
    {
        InvokeRepeating("SpawnBox", 2, 5);
    }

    private void SpawnBox()
    {
        float randomXvalue = Random.Range(-widthValue, widthValue);
        float topYPosition = 10f; // Adjust this value as needed
        Vector3 pos = new Vector3(randomXvalue, topYPosition, 0);
        GameObject box = Instantiate(boxPrefab, pos, Quaternion.identity);
        BoxMovement boxMovement = box.GetComponent < BoxMovement>();

        int rndValue = Random.Range(0, 3);
    }
}