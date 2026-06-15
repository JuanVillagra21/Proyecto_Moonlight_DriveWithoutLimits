using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovimiento : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del auto
    public float tiempoDeVida = 10.0f; // Tiempo antes de que el auto desaparezca

    void Start()
    {
        // Comienza a contar el tiempo hasta que el auto deba desaparecer
        Invoke("DesaparecerAuto", tiempoDeVida);
    }

    void Update()
    {
        // Mueve el auto hacia abajo en el eje Y
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);
    }

    void DesaparecerAuto()
    {
        // Agregar aquí el código para hacer que el auto desaparezca
        Destroy(gameObject);
    }
}
