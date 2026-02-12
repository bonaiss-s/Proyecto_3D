using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    public Rigidbody rb;
    private bool ismove;

    float velocidad = 5;    

    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        if (ismove)
        {
            rb.linearVelocity = playerController.Direccion() * velocidad;

        }
    }
}
