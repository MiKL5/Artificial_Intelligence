using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    Vector2 dir;
    CamShaker cs;

    // la direction par défaut
    void Start()
    {
        dir = Vector2.one.normalized;
        cs = Camera.main.GetComponent<CamShaker>();
    }

    // le mouvement
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        // la balle se cogne en haut et en bas
        if ( (transform.position.y < -3.9f && dir.y < 0)
        ||   (transform.position.y > 5.9f && dir.y > 0) )
        {
            dir.y *= -1; // inverse la direction
        }
        // vérifier si la balle sor de l'écran
        if (transform.position.x < -7.5f && dir.x < 0)
        {
            // le joueur gange
            transform.position = Vector2.zero;
        }
        if (transform.position.x > 7.5f && dir.x > 0)
        {
            // l'IA gagne
            transform.position = Vector2.zero;
        }
    }
    // gérer les collisions avec les paddles
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "paddle") 
        {
            bool isPlayer = collision.GetComponent<bar>().isHumanPlayer;
            if ( (isPlayer && dir.x > 0 ) || (isPlayer && dir.x < 0 ) )
            {
                dir.x *= -1;
            }
        }
    }
}
