using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueAlJugador : MonoBehaviour
{
    private Vector3 desplazamiento;
    private Vector3 posicion;
    /* El profesor lo hizo asignandole un valor fijo así:
    private Vector3 Desplazamiento = new Vector3(0,6.8,-9.7)
    Pero yo lo hice con asignando a la variable desplazamiento la posición inicial
    antes de que se ejecute el primer frame del juego porque me parece más cómodo */
    public GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {
        //Se asigna la distancia que va a mantener la camara del jugador
        desplazamiento = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicion = Jugador.transform.position + desplazamiento;
        
        transform.position = posicion;
        /*intento fallido de que la camara gire con la camioneta
        
        rotacionCamara = new Vector3(-Jugador.transform.rotation.y, 0, 0);

        transform.position = posicion + (rotacionCamara * mult);

        transform.rotation = Jugador.transform.rotation;*/
    }
}
