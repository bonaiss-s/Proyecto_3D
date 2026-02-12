using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private Renderer _render;
    [SerializeField]
    private Material material1;
    [SerializeField]
    private Material material2;

    [SerializeField]

    private PlayerController controller;
    void Start()
    {
        _render = GetComponent<Renderer>();

       controller = GetComponent<PlayerController>();

        controller.Direccion();


        

    }

 
    void Update()
    {
        Cambiarcolor();
       
    }

    public void Cambiarcolor()
    {
        if (controller.Direccion() magnitud > 0 ) {
        
         _render.material color = Color.red;

        }

    }
}
