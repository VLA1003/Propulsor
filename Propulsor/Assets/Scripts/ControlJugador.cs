using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    Rigidbody2D body;
    Vector2 direction;

    [SerializeField]
    float velocidadJugador = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 75;
        body = GetComponent<Rigidbody2D>();
    }

    // Control del jugador con las teclas de dirección/joystick basándose en el Vector2 y en un valor de velocidad serializado
    // que se han llamado al principio.
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadJugador;
        direction.y = Input.GetAxis("Vertical") * Time.deltaTime * velocidadJugador;
    }

    // Fuerza de impulso en la que se basa el movimiento del jugador.
    private void FixedUpdate()
    {
        body.AddForce(direction, ForceMode2D.Impulse);
    }
}
