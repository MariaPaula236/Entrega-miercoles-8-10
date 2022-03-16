using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour
{
    public GameObject characterPrincipal;
    public float velocidad = 5f;
    public GameObject bala;

    // Start is called before the first frame update
    void Start(){
        transform.position = new Vector3(-3.452276F, 0.1900001F, -3.704882F);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        { 
            transform.position -= Vector3.forward * velocidad * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right * velocidad * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);

        }

        if (Input.GetKeyDown(KeyCode.A)){
            transform.position += transform.forward * velocidad * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.Space)){
            Instantiate (bala, transform.position, transform.rotation);
        }
    }
}
