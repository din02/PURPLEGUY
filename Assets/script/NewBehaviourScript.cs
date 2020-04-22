using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 20f;
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("p"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 0, 0); //flip sprite
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0, 180, 0); //flip sprite
        }
        transform.position = pos;
    }
}