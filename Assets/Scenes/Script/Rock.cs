using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Carro")
        {
            Debug.Log("Game Over");
            Application.LoadLevel("escena1");
        }
    }
}