using UnityEngine;

public class Destruir_Basquet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Canasta"))
        {
            Destroy(gameObject); 
        }
    }
}