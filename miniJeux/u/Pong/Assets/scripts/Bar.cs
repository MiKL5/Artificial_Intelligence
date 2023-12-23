using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public bool isHumanPlayer = false; // machine ou humain ?
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float move;
        // calcul du mvmt
        if(isHumanPlayer) {
            move = Input.GetAxis("Vertial") * speed * Time.deltaTime;
        } else {
            move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        // appliquer le mvmt
        transform.Translate(move * Vector2.up); // si négatif ce sera .down
    }
}
