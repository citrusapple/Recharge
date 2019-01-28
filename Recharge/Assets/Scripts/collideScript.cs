using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour
{
    public AudioSource sound;
    private void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
        if (collision.collider.name != "Player")
            return;

        Player player = collision.collider.GetComponent<Player>();

        if(player == null)
        {
            Debug.LogError("Something is wrong!");
        }

        player.AddScore();
        Destroy(gameObject, 0.02f);
    }


}
