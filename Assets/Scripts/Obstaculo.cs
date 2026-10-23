using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculo : MonoBehaviour
{
    public float velocidadGiro = 50f;

    public float velocidadMovimiento = 3f;
    public float alturaMinima = -3f;    
    public float alturaMaxima = 3f;    
    public bool invertirDireccion = false; 
    private float posicionInicialX;

    public GameObject panelGameOver;

    void Start()
    {
        posicionInicialX = transform.position.x;
    }

    void Update()
    {
        transform.Rotate(0, 0, velocidadGiro * Time.deltaTime);

        float desfase = invertirDireccion ? Mathf.PI : 0f; 
        float avance = Mathf.PingPong(Time.time * velocidadMovimiento + desfase, alturaMaxima - alturaMinima);
        float nuevoY = alturaMinima + avance;

        transform.position = new Vector3(posicionInicialX, nuevoY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Circle" || collision.CompareTag("Pelota"))
        {
            if (panelGameOver != null)
            {
                panelGameOver.SetActive(true);
            }

            Time.timeScale = 0f;
        }
    }
}