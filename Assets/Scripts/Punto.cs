using UnityEngine;

public class Punto : MonoBehaviour
{
    public int valorPunto = 100;

    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -3.5f;
    public float maxY = 3.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Circle" || collision.CompareTag("Pelota"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.SumarPuntos(valorPunto);
            }

            MoverA_PosicionAleatoria();
        }
    }

    void MoverA_PosicionAleatoria()
    {
        float nuevoX = Random.Range(minX, maxX);
        float nuevoY = Random.Range(minY, maxY);
        transform.position = new Vector3(nuevoX, nuevoY, 0f);
    }
}