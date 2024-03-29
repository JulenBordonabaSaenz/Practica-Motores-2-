﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCollisiones : MonoBehaviour
{
    [HideInInspector]
    public string nombreCollider;

    public BoxCollider trigger1;
    private Transform jugador;

    private void Awake()
    {
        jugador = gameObject.transform.parent;
        nombreCollider = gameObject.name.ToString();
        Debug.Log(nombreCollider);
        Debug.Log(jugador.name);
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ColliderDelante")
        {
            if(nombreCollider == "ColliderDelante")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 1;
                print(gameObject.name);
                return;
            }
            else if (nombreCollider == "ColliderAtras")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 1;
                print(gameObject.name);
                return;
            }
            else if (nombreCollider == "ColliderLados")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 1;
                print(gameObject.name);
                return;
            }
        }
        else if (other.gameObject.name == "ColliderAtras")
        {
            if (nombreCollider == "ColliderDelante")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 5;
                print(gameObject.name);
                return;

            }
            else if (nombreCollider == "ColliderAtras")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 5;
                print(gameObject.name);
                return;
            }
            else if (nombreCollider == "ColliderLados")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 5;
                print(gameObject.name);
                return;
            }
        }
        else if (other.gameObject.name == "ColliderLados")
        {
            if (nombreCollider == "ColliderDelante")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 3;
                print(gameObject.name);
                return;

            }
            else if (nombreCollider == "ColliderAtras")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 3;
                print(gameObject.name);
                return;
            }
            else if (nombreCollider == "ColliderLados")
            {
                other.gameObject.GetComponent<ManagerCollisiones>().jugador.GetComponent<Controlarvelocidad>().puntosEstabilidad -= 3;
                print(gameObject.name);
                return;
            }
        }

    }

}
