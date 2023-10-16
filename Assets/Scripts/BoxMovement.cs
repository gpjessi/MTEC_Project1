using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public SpriteRenderer sr;
    public float boxSpeed = 2;
    public float FallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        FallSpeed = Random.Range(1f, 3f);
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -FallSpeed * Time.deltaTime, 0);
    }

    
}
