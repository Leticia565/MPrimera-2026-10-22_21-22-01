using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int puntosTotales = 0;
    public TextMeshProUGUI textoPuntajeUI; 

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ActualizarTextoUI();
    }

    public void SumarPuntos(int cantidad)
    {
        puntosTotales += cantidad;
        ActualizarTextoUI();
    }

    void ActualizarTextoUI()
    {
        if (textoPuntajeUI != null)
        {
            textoPuntajeUI.text = "Puntos: " + puntosTotales;
        }
    }
}