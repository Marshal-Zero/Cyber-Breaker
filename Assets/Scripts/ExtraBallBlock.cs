using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallBlock : MonoBehaviour
{
    [SerializeField] Rigidbody2D extraBall;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); //destroys the game object that the script is sitting on                
        ExtraBall();
    }


    private void ExtraBall()
    {
        extraBall = Instantiate(extraBall, transform.position, transform.rotation);
        extraBall.velocity = new Vector2(2f, 10f);
    }
}
