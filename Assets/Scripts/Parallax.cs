using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cam;
    private float length, startPos;
    private float currentParallaxSpeed; // Velocidad actual del parallax
    private bool playerLost = false; // Variable para controlar si el jugador ha perdido
    public float parallaxEffect; // Esta es la variable que controla la velocidad predeterminada del parallax

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        currentParallaxSpeed = parallaxEffect; // Inicializa la velocidad actual con la velocidad predeterminada
    }

    void Update()
    {
        // Si el jugador no ha perdido, se aplica el efecto de parallax con la velocidad actual
        if (!playerLost)
        {
            transform.position = new Vector3(transform.position.x - currentParallaxSpeed, transform.position.y, transform.position.z);
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

    // Método público para ajustar la velocidad del parallax manualmente
    public void SetParallaxSpeed(float speed)
    {
        currentParallaxSpeed = speed;
    }
}