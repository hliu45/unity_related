using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public float thrust;
    private int count;
    public Text countText;
    public Text winText;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;

    private float nextJump;
    public float jumpRate;

    private void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winText.text = "";  
    }

    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (transform.position.y < 0.505f)
        {
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }
        else if (transform.position.y < 1.51f && transform.position.y > 1.47f && transform.position.x < 8.5f && transform.position.x > 5.41f 
            && transform.position.z < 7f && transform.position.z > -2.6f)
        {
            //L1
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }
        else if (transform.position.y < 3.71f && transform.position.y > 2.67f && transform.position.x < 9f && transform.position.x > -6.5f 
            && transform.position.z < 11.5f && transform.position.z > 7.3f)
        {
            //L2
            movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);
        }

        if (transform.position.y < 5.2f && transform.position.y > 3.83f && transform.position.x < -4f && transform.position.x > -7.4f 
            && transform.position.z < 7.8f && transform.position.z > -3.4f)
        {
            //L3
            movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);
        }
        else if (transform.position.y < 6.31f && transform.position.y > 4.97f && transform.position.x < 2.0f && transform.position.x > -4.7f 
            && transform.position.z < 1.3f && transform.position.z > -3.5f)
         {
            //L4
            movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);
         }
            else if (transform.position.y < 8.31f && transform.position.y > 6.47f && transform.position.x < 2.3f && transform.position.x > -2.65f 
            && transform.position.z < -3.0f && transform.position.z > -9.8f)
         {
            //L5
            movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);
         }
            else if (transform.position.y < 9.31f && transform.position.y > 7.97f && transform.position.x < -2f && transform.position.x > -8.5f 
            && transform.position.z < -4.2f && transform.position.z > -8.7f)
         {
            //L6
            movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);
         }
            else if (transform.position.y < 10.51f && transform.position.y > 9.47f && transform.position.x < -9.0f && transform.position.x > -14.4f 
            && transform.position.z < -3.0f && transform.position.z > -10.3f)
         {
            //L7
            movement = new Vector3(-moveVertical, 0.0f, moveHorizontal);
         }
       

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space") && Time.time>nextJump)
        {
            nextJump = Time.time + jumpRate;
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            SetCountText();
        }
    } 

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 100)
        {
            winText.text = "You Win!!";
        }
    }
}
