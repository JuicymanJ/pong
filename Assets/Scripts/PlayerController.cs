using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            float speed = moveSpeed * Time.deltaTime;
            transform.position += new Vector3(0,speed);
        }
        if (Input.GetKey(downKey))
        {
            float speed = moveSpeed * Time.deltaTime;
            transform.position -= new Vector3(0, speed);
        }
    }
}
