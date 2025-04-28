using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;

    // Start is called before the first frame update
    void Start()
    {
        if (periodoDeDias < 5)
        {
            Debug.Log("cantidad de dias no valido");
            return;
        }
        if (cantidadDeUnidades < 1)
        {
            Debug.Log("cantidad de unidades no valido");
            return;
        }

        int kmPorDia = 90;
        int kmPorLitro = 15;
        int pesosPorLitro = 130;
        int descuentoPorcentaje = 20;

        int kmTotales = cantidadDeUnidades * periodoDeDias * kmPorDia;
        int litrosEnTotal = kmTotales / kmPorLitro;
        int costoTotalCombustible = litrosEnTotal * pesosPorLitro;

        if (litrosEnTotal > 100)
        {
            int montoDescuento = (costoTotalCombustible * descuentoPorcentaje) / 100;
            int costoFinalConDescuento = costoTotalCombustible - montoDescuento;
            Debug.Log("Se aplica un descuento de " + montoDescuento + " pesos El costo final con descuento es " + costoFinalConDescuento + " pesos.");
        }
        else
        {
            Debug.Log("No se aplica descuento");
        }




    }

    


    // Update is called once per frame
    void Update()
    {
        
    }
}
