using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamañoJugador : MonoBehaviour
{
    public float MovimientoX;
    public float MovimientoY;
    public float MovimientoZ;
    string jugador;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale += new Vector3(MovimientoX, MovimientoY, MovimientoZ);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
