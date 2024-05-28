using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Par�metros", menuName = "Scriptable Objects/Par�metros", order = 1)]

public class Parametros : ScriptableObject
{
    [SerializeField] string nombre;
    [SerializeField] int vida;
    [SerializeField] string saludo;

    public string Nombre { get { return nombre; } }
    public int Vida { get { return vida; } }
    public string Saludo { get {  return saludo; } }
}
