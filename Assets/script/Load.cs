using UnityEngine;
using System.Collections;
public class Load : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D block)
    {
        if (block.gameObject.tag == "Player")
            Application.LoadLevel("Level2");
    }
}