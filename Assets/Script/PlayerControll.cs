using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed = 100f; // Valor predeterminado de 100

    // Update is called once per frame
    void Update()
    {
        // Input para el movimiento hacia adelante (Vertical)
        float verticalInput = Mathf.Clamp(Input.GetAxis("Vertical"), 0, 1);

        // Input para el giro (Horizontal: -1 izquierda, 1 derecha)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Movimiento hacia adelante
        if (verticalInput > 0)
        {
            Vector3 forwardMovement = transform.up * speed * verticalInput * Time.deltaTime;
            transform.Translate(forwardMovement, Space.World);

            // Solo girar si el coche se está moviendo hacia adelante
            float turnAngle = horizontalInput * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -turnAngle); // Rotación sobre el eje Z
        }
    }
}