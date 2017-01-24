using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    private Vector3 target;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (player.transform.position.y < 0.505f)
        {
            transform.position = new Vector3(-0.21f, 21.0f, -15.0f);
            transform.eulerAngles = new Vector3(55, 0, 0);
            target = new Vector3(-0.21f, 21.0f, -15.0f);
            offset = target - player.transform.position;

        }
        else if (player.transform.position.y < 1.51f && player.transform.position.y > 1.47f && player.transform.position.x < 8.5f && 
            player.transform.position.x > 5.41f && player.transform.position.z < 7f && player.transform.position.z > -2.6f)
        {
            transform.position = new Vector3(7.4f, 4.5f, -4f); //camera position
            transform.eulerAngles = new Vector3(34, 0, 0);
            target = new Vector3(7.4f, 4.5f, -4f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 3.71f && player.transform.position.y > 2.67f && player.transform.position.x < 9f && 
            player.transform.position.x > -6.5f && player.transform.position.z < 11.5f && player.transform.position.z > 7.3f)
        {
            transform.position = new Vector3(11.5f, 6.7f, 10f); //camera position
            transform.eulerAngles = new Vector3(35.37f, -89.2f, 0);
            target = new Vector3(11.5f, 6.7f, 10f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 4.91f && player.transform.position.y > 3.83f && player.transform.position.x < -4f && 
            player.transform.position.x > -7.4f && player.transform.position.z < 7.8f && player.transform.position.z > -3.4f)
        {
            transform.position = new Vector3(-5.9f, 7.3f, 10.8f); //camera position
            transform.eulerAngles = new Vector3(36.0f, -187.5f, -1f);
            target = new Vector3(-5.9f, 7.3f, 10.8f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 6.01f && player.transform.position.y > 4.97f && player.transform.position.x < 2.0f && 
            player.transform.position.x > -4.7f && player.transform.position.z < 1.3f && player.transform.position.z > -3.5f)
        {
            transform.position = new Vector3(-8.49f, 8.8f, 0.5f); //camera position
            transform.eulerAngles = new Vector3(37.6f, -272.2f, 0);
            target = new Vector3(-8.49f, 8.8f, 0.2f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 7.51f && player.transform.position.y > 6.47f && player.transform.position.x < 2.3f && 
            player.transform.position.x > -2.65f && player.transform.position.z < -3.0f && player.transform.position.z > -9.8f)
        {
            transform.position = new Vector3(-0.5f, 9.0f, -0.3f); //camera position
            transform.eulerAngles = new Vector3(38.2f, -176f, 0);
            target = new Vector3(-0.5f, 9.0f, -0.3f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 9.01f && player.transform.position.y > 7.97f && player.transform.position.x < -1.9f && 
            player.transform.position.x > -9.2f && player.transform.position.z < -4.3f && player.transform.position.z > -9.1f)
        {
            transform.position = new Vector3(-0.5f, 10.8f, -6.0f); //camera position
            transform.eulerAngles = new Vector3(38f, -91.7f, 0);
            target = new Vector3(-0.5f, 10.8f, -6.0f);
            offset = target - player.transform.position;
        }
        else if (player.transform.position.y < 10.51f && player.transform.position.y > 9.47f && player.transform.position.x < -9.0f && 
            player.transform.position.x > -14.4f && player.transform.position.z < -3.0f && player.transform.position.z > -10.3f)
        {
            transform.position = new Vector3(-3.5f, 11.5f, -6.0f); //camera position
            transform.eulerAngles = new Vector3(38f, -91.7f, 0);
            target = new Vector3(-3.5f, 11.5f, -6.0f);
            offset = target - player.transform.position;
        }

        transform.position = player.transform.position + offset;
    }
}
