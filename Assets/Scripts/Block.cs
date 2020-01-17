using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); //destroys the game object that the script is sitting on                




    }
}
//Rigidbody2D extraTrigger = Instantiate(extraBall, transform.position, transform.rotation);
//extraTrigger.velocity = new Vector2(2f, 10f);