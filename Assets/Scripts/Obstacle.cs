using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D other) {
        //Deletes clones obstacle game objects
        if (other.collider.tag == "Destroy"){
            // Adds score
            Destroy(gameObject);
        }

        if (other.collider.tag == "Player"){
            Destroy(player.gameObject);
        }
    }
}
