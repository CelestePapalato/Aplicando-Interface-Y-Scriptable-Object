using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour, IPresentacion, ITakeDamage
{
    [SerializeField] Parametros parametros;

    int vidaActual;

    private void Awake()
    {
        if (!parametros) { return; }
        vidaActual = parametros.Vida;
    }

    public void Accion()
    {
        Debug.Log(parametros.Saludo);
    }

    public void Da�o(int puntosDeDa�o)
    {
        vidaActual -= puntosDeDa�o / 2;
        if(vidaActual < 0)
        {
            Debug.Log("Estoy muerto de hace rato");
        }
        else
        {
            Debug.Log("Apenas lo sent�. Solo recibo la mitad de da�o. A�n me quedan " + vidaActual + " puntos de vida.");
        }
    }
}
