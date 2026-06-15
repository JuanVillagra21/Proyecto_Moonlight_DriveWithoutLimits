using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAcelerometro : MonoBehaviour
{
    // Puedes ajustar estos valores según sea necesario
    public float factorDeVelocidadX = 25.0f;
    public float factorDeVelocidadY = 25.0f;

   

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.x;
        dir.y = Input.acceleration.y;
        dir.z = Input.acceleration.z;

        //Debug.Log(dir.x.ToString());

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;

        // Ahora, mueve el objeto en ambos ejes X e Y
        transform.Translate(new Vector3(
            dir.x * factorDeVelocidadX,
            dir.y * -factorDeVelocidadY,
            0));

        
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
}