using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMovement : MonoBehaviour
{

    public SpriteRenderer sr;
    public float hazardSpeed = 2;

    public float FallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        FallSpeed = Random.Range(1f, 2f);
        sr = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        //transform.Translate(hazardSpeed * Time.deltaTime, 0, 0);
        transform.Translate( 0, -FallSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
