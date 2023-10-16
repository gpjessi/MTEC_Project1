using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip coinClip;
   
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {


        audioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(speed * Time.deltaTime * xInput,0, 0);
        

        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {

            Destroy(collision.gameObject);
          

        }
        else if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(coinClip);
        }
        else if (collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            print("Collided With Player");
        }
    }

   
}
