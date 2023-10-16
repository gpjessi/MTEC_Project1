using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Pro : MonoBehaviour
   

{
    public GameObject coinPrefab;
   
    private float widthValue = 8;
     
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 4, 2);
  
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnCoin()
    {
        float randomXvalue = Random.Range(-widthValue, widthValue);

        Vector3 pos = new Vector3(randomXvalue, 5.5f, 0);
        GameObject coin = Instantiate(coinPrefab, pos, Quaternion.identity); // Spawn the coin

        CoinScript coinScript = coin.GetComponent<CoinScript>();
       

        int rndValue = Random.Range(0, 3);
        coinScript.ChangeCoinValue(rndValue);
        
    }
}
