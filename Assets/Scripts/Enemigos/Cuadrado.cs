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

    public void Daño(int puntosDeDaño)
    {
        vidaActual -= puntosDeDaño;
        if (vidaActual < 0)
        {
            Debug.Log("Sigue nomás, sigue hasta que encuentres el negativo más chiquito. Tengo " + vidaActual + " puntos de vida");
        }
        else
        {
            Debug.Log("Malévolo. Ahora solo me quedan " + vidaActual + " puntos de Vida");
        }
    }
}
