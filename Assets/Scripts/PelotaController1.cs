using UnityEngine;

public class PelotaController1 : MonoBehaviour
{
    private Rigidbody2D rb;

    public float velocidadHorizontal = 6f;
    public float fuerzaReboteVertical = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimientoX = 0f;
        if (Input.GetKey(KeyCode.A)) movimientoX = -1f;
        if (Input.GetKey(KeyCode.D)) movimientoX = 1f;

        rb.linearVelocity = new Vector2(movimientoX * velocidadHorizontal, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * fuerzaReboteVertical, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.down * fuerzaReboteVertical, ForceMode2D.Impulse);
        }
    }
}