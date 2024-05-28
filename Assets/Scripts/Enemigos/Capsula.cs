using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula : MonoBehaviour, IPresentacion, ITakeDamage
{
    [SerializeField] Parametros parametros;

    public void Accion()
    {
        Debug.Log(parametros.Saludo + "Mi nombre es " + parametros.Nombre);
    }

    public void Da�o(int puntosDeDa�o)
    {
        Debug.Log("Soy inmune. A�n tengo mis " + parametros.Vida + " puntos de vida.");
    }
}
