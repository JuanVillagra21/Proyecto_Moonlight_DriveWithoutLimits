using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAcelerometro : MonoBehaviour
{
    public GameObject panelPausa;

    public float factorDeVelocidadX = 25.0f;
    public float factorDeVelocidadY = 25.0f;

    // Velocidad de retroceso (S)
    public float velocidadRetroceso = 0.5f;

    // Límites de la pista (ajustar según sea necesario)
    private  float limiteIzquierdo = -17f;
    private float limiteDerecho = 15f;

    bool estaPausado = false;

    public void ReanudarJuego()
    {
        Time.timeScale = 1f;
        estaPausado = false;
        panelPausa.SetActive(false);
    }

    void Update()
    {
        // PAUSA
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado)
            {
                Time.timeScale = 1f;
                estaPausado = false;
                panelPausa.SetActive(false);
            }
            else
            {
                Time.timeScale = 0f;
                estaPausado = true;
                panelPausa.SetActive(true);
            }
        }

        Vector3 dir = Vector3.zero;

#if UNITY_ANDROID
        dir.x = -Input.acceleration.x;
        dir.y = Input.acceleration.y;
#else
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        dir.x = moveX;

        // Si retrocede (S), va más lento
        if (moveY < 0)
        {
            dir.y = moveY * velocidadRetroceso;
        }
        else
        {
            dir.y = moveY;
        }
#endif

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        transform.Translate(new Vector3(
            dir.x * factorDeVelocidadX,
            dir.y * factorDeVelocidadY,
            0));

        // Limitar movimiento dentro de la pista
        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, limiteIzquierdo, limiteDerecho);
        transform.position = posicion;
    }
    // NUEVO: ganar al llegar a la meta
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Meta"))
        {
            FindObjectOfType<ControladorDeTiempo>().GanarJuego();
        }
    }
}
