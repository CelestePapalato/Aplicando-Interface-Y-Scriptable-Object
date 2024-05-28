using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : MonoBehaviour, IPresentacion, ITakeDamage
{
    [SerializeField] Parametros parametros;

    int vidaActual;

    private void Awake()
    {
        if (!parametros) {  return; }
        vidaActual = parametros.Vida;
    }

    public void Accion()
    {
        Debug.Log(parametros.Saludo);
    }

    public void Da�o(int puntosDeDa�o)
    {
        vidaActual -= puntosDeDa�o;
        if (vidaActual < 0)
        {
            Debug.Log("Sigue nom�s, sigue hasta que encuentres el negativo m�s chiquito. Tengo " + vidaActual + " puntos de vida");
        }
        else
        {
            Debug.Log("Mal�volo. Ahora solo me quedan " + vidaActual + " puntos de Vida");
        }
    }
}
