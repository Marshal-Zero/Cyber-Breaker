using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseTrigger : MonoBehaviour
{
           
    private void  OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (collision.gameObject.tag == "Lose")
        {
            Debug.Log("triggered");
            Destroy(GameObject.FindGameObjectWithTag("Lose"));
            SceneManager.LoadScene("Game Over");           
        }       
    }

}
