using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cam;
    private float length, startPos;
    public float parallaxEffect;

    private bool playerLost = false; // Variable para controlar si el jugador ha perdido

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Si el jugador no ha perdido, se aplica el efecto de parallax
        if (!playerLost)
        {
            transform.position = new Vector3(transform.position.x - parallaxEffect, transform.position.y, transform.position.z);
            if (transform.localPosition.x < -20)
            {
                transform.localPosition = new Vector3(20, transform.localPosition.y, transform.localPosition.z);
            }
        }
    }

    // Método para detener el parallax cuando el jugador pierde
    public void PlayerLost()
    {
        playerLost = true;
        // Puedes agregar aquí cualquier otra lógica relacionada con la pérdida del jugador, como detener la música, mostrar un mensaje de game over, etc.
    }
}