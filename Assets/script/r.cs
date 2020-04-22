using UnityEngine;
using System.Collections;
public class r : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D block2)
    {
        if (block2.gameObject.tag == "Player")
            Application.LoadLevel("WON");
    }
}