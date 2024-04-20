using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Aqu�, obt�n una referencia al componente Parallax y llama a su m�todo PlayerLost() para detener el parallax
            Parallax parallax = FindObjectOfType<Parallax>();
            if (parallax != null)
            {
                parallax.PlayerLost();
            }
        }
    }
}