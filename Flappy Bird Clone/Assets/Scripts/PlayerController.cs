using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region VARIABLES

    public Rigidbody2D rb;
    public bool isDead = false; // Indica si el jugador está muerto
    [SerializeField] private float jumpForce = 10f; // Fuerza del salto

    #endregion

    #region METHODS
    // Awake is called once before Start when the script instance is being initialized. Used to set up references.
    void Awake()
    {
        GetComponent<Rigidbody2D>(); // Obtiene el componente Rigidbody2D del GameObject al que está adjunto este script
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        
    }
    
    // Update is called once per frame. Used to see what the player does each frame.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // Detecta si se presiona la tecla de espacio o el botón izquierdo del ratón
        {
            Jump(); // Llama al método Jump para realizar el salto
        }
        
        
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Aplica una fuerza hacia arriba al Rigidbody2D
        Debug.Log("Salto realizado");
    }

    #endregion

}
