using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour
{
    public int Points = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "plus")
        {
            Points++;
            if(Points > 10)
            {
                SceneManager.LoadScene("win");
            }
        }
        else if (collision.gameObject.tag == "minus")
        {
            Points++;
            if (Points < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}
