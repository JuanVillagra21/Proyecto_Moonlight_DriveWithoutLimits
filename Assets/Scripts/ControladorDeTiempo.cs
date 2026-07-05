using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeTiempo : MonoBehaviour
{
    public float tiempoLimite = 35.0f;
    private float tiempoRestante;
    public TextMeshProUGUI mensajeVictoria; // Referencia al objeto de texto de victoria
    private bool juegoTerminado = false;

    public delegate void VictoriaEventHandler();
    public event VictoriaEventHandler OnVictoria;

    void Start()
    {
        tiempoRestante = tiempoLimite;
        mensajeVictoria.gameObject.SetActive(false); // Asegúrate de que el mensaje de victoria esté desactivado al inicio
    }

    void Update()
    {
        if (juegoTerminado)
            return;

        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0)
        {
            juegoTerminado = true;
            tiempoRestante = 0;

            // Cambiá este nombre por tu escena de derrota por tiempo
            SceneManager.LoadScene("Perdiste");
        }
    }

    public void GanarJuego()
    {
        if (juegoTerminado)
            return;

        juegoTerminado = true;

        if (OnVictoria != null)
        {
            OnVictoria();
        }

        MostrarMensajeDeVictoria();
    }

    void MostrarMensajeDeVictoria()
    {
        mensajeVictoria.gameObject.SetActive(true);

        Invoke("CargarEscenaDeVictoria", 1.0f);
    }

    void CargarEscenaDeVictoria()
    {
        SceneManager.LoadScene("Victoria");
    }
}
