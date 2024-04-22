using UnityEngine;

public class Controller_Enemy : MonoBehaviour
{
    public static float enemyVelocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(new Vector3(-enemyVelocity, 0, 0), ForceMode.Force);
        OutOfBounds();
    }

    public void OutOfBounds()
    {
        if (this.transform.position.x <= -15)
        {
            Destroy(this.gameObject);
        }
    }

    // Método para recibir daño del jugador
    public void TakeDamage(Vector3 shootDirection)
    {
        // Aquí puedes implementar la lógica para restar vida al enemigo
        // Por ejemplo, puedes aplicar una fuerza al enemigo en la dirección del disparo
        rb.AddForce(shootDirection * 10, ForceMode.Impulse);
        // Puedes también implementar lógica para verificar si el enemigo ha muerto
        // Si es así, puedes destruir el objeto del enemigo
        Destroy(this.gameObject);
    }
}