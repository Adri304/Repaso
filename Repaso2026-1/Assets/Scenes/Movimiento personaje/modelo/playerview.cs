using UnityEngine;

public class playerview : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private Material material1;
    [SerializeField] private Material material2;


    [SerializeField] private PlayerControles controller;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        controller = GetComponent<PlayerControles>();

        
    }

    // Update is called once per frame
    void Update()
    {
        CambiarColor();
        Debug.Log(controller.DirectionJugador().magnitude);
    }

    public void CambiarColor()
    {
        if (controller.DirectionJugador().magnitude > 0)
        {
            renderer.material.color = Color.red;
        }
        else
        {
            renderer.material.color = Color.blue;
        }
    }
}
