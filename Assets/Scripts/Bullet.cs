using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f; // Velocidad de la bala

    void Start()
    {
        // Aplicar velocidad a la bala en la direcci�n hacia adelante
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si la bala colisiona con un objeto que tiene el tag "Enemy", destr�yela
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}