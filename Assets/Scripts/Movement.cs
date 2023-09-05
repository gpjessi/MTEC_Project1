using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        

      

        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(speed * Time.deltaTime * xInput, 0, 0);
        

        }
}
