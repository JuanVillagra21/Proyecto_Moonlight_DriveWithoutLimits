using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAcelerometro : MonoBehaviour
{
    // Puedes ajustar estos valores según sea necesario
    public float factorDeVelocidadX = 25.0f;
    public float factorDeVelocidadY = 25.0f;

    // Límites de la pista
    private float limiteIzquierdo = -17f;
    private float limiteDerecho = 15f;

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.x;
        dir.y = Input.acceleration.y;
        dir.z = Input.acceleration.z;

        // Evita que el auto retroceda
        dir.y = Mathf.Min(0f, dir.y);

        //Debug.Log(dir.x.ToString());

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        // Ahora, mueve el objeto en ambos ejes X e Y
        transform.Translate(new Vector3(
            dir.x * factorDeVelocidadX,
            dir.y * -factorDeVelocidadY,
            0));

        // Limitar movimiento dentro de la pista
        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, limiteIzquierdo, limiteDerecho);
        transform.position = posicion;
    }

    Vector3 GetAccelerometerValue()
    {
        Vector3 acc = Vector3.zero;
        float period = 0.0f;

        foreach (AccelerationEvent evt in Input.accelerationEvents)
        {
            acc += evt.acceleration * evt.deltaTime;
            period += evt.deltaTime;
        }

        if (period > 0)
        {
            acc *= 1.0f / period;
        }

        return acc;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Meta"))
        {
            FindObjectOfType<ControladorDeTiempo>().GanarJuego();
        }
    }
}