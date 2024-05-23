using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidad;
    public float velocidadGiro = 63;
    private float controlHorizontal;
    private float controlAvance;
    public GameObject[] ruedas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Leemos el sistema de entrada
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");
        // Control caída
        if (transform.position.y > -1 && transform.position.y < 0.7f)
        {
            // Control de avance
            velocidad = 20.0f * controlAvance;
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        // Control de giro
        if (controlAvance == 0)
        {
            controlHorizontal = 0;
        }
        if (controlAvance >= 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * controlHorizontal);
        }
        else
        {
            transform.Rotate(Vector3.down, Time.deltaTime * velocidadGiro * controlHorizontal);
        }
        // Animacion de ruedas
        /*if(controlAvance > 0)
        {
            ruedas.
        }*/
    }
}
