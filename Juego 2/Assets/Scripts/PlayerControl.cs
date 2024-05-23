using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalMove;
    public float speed = 25;
    public float horizontalLimit = 20;
    public GameObject proyectilPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        //lanzamiento de comida
        if(Input.GetKeyDown(KeyCode.Space)) { 
        Instantiate(proyectilPrefab,transform.position + new Vector3(0,1.49f,0),proyectilPrefab.transform.rotation);
        }

        //movimiento jugador
        if (transform.position.x < -horizontalLimit) {
        transform.position = new Vector3 (-horizontalLimit,transform.position.y, transform.position.z);
        }
        else if(transform.position.x > horizontalLimit)
        {
            transform.position = new Vector3(horizontalLimit, transform.position.y, transform.position.z);
        }

        horizontalMove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalMove * Time.deltaTime * speed);
    }
}
