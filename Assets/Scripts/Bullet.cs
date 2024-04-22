using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f; // Velocidad de la bala

    void Start()
    {
        // Aplicar velocidad a la bala en la dirección hacia adelante
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si la bala colisiona con un objeto que tiene el tag "Enemy", destrúyela
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}