using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioExamen : MonoBehaviour
{
    // Start is called before the first frame update
    public int monto;
    public string moneda;
    void Start()
    {
        if (moneda != "D" && moneda != "R" && moneda != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida");
        } else if (monto < 1000)
        {
            Debug.Log("El monto mínimo es 1000");
        } else if (moneda == "D")
        {
            float convert = monto / 110;
            Debug.Log(monto + " pesos argentinos equivalen a " + convert + " dólares.");
        } else if (moneda == "R")
        {
            float convert = monto / 25;
            Debug.Log(monto + " pesos argentinos equivalen a " + convert + " reales.");
        } else if (moneda == "E")
        {
            float convert = monto / 120;
            Debug.Log(monto + " pesos argentinos equivalen a " + convert + " euros.");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
