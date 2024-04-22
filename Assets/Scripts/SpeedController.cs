using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public Parallax parallaxScript; // Referencia al script de Parallax

    void Start()
    {
        // Ajusta la velocidad del parallax a la mitad de su velocidad original
        parallaxScript.SetParallaxSpeed(parallaxScript.parallaxEffect / 2);
    }
}