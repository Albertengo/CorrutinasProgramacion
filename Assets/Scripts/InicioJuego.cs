using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioJuego : MonoBehaviour
{
    public Text contador;
    int tiempo = 3;
    public GameObject pantalla;

    void Start()
    {
        StartCoroutine(CuentaRegresiva());
    }

    IEnumerator CuentaRegresiva()
    {
        while (tiempo > 0)
        {
            contador.text = "El juego comenzará en: " + tiempo;
            tiempo--;
            yield return new WaitForSeconds(1f);
        }
        pantalla.SetActive(false);
    }
}
