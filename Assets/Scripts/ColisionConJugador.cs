using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionConJugador : MonoBehaviour
{
   // Puedes ajustar el nombre del tag según el que hayas asignado al objeto vacío
    public string spawnPointTag = "SpawnPoint";

    private void OnTriggerEnter(Collider collision)
    {
        // Verifica si la colisión involucra al jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisión con el jugador");

            // Ejemplo: destruir el objeto del spawn point
            if (transform.CompareTag(spawnPointTag))
            {
                Destroy(gameObject);
            }
            // Obtener un índice aleatorio para elegir la escena
            int indiceEscena = Random.Range(0, 3); // Cambia 3 según la cantidad de escenas

            // Crear un array con los nombres de tus escenas de "perdiste"
            string[] nombresEscenasPerdiste = {"Perdiste 2", "Perdiste 3" , "Perdiste 4"}; // Reemplaza con los nombres reales

            // Obtener el nombre de la escena seleccionada
            string nombreEscenaSeleccionada = nombresEscenasPerdiste[indiceEscena];

            // Cambiar a la escena seleccionada
            SceneManager.LoadScene(nombreEscenaSeleccionada);

        }

    }
    

}
