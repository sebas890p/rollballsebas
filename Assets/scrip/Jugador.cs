using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad;
    public Rigidbody fisica;
    private int puntos;

    // Start is called before the first frame update
    void Start()
    {
       fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimientos = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        fisica.AddForce(movimientos * velocidad);
    }

    void OnGUI ()
    {
        GUI.Box(new Rect(0,0,100,50), "Score: " + puntos);
    }
    void OnTriggerEnter(Collider colision)
    {
        if (colision.CompareTag("Moneda"))
        {
            puntos++;
        }
    }

    
}
