using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hero")
        {
            Destroy(gameObject);
        }
    }
}
