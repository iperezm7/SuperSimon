using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int[] secuenciaJugador = new int[5];

    [SerializeField] int indiceActualJugador;
    [SerializeField] GenerarSecuencias generarSecuencias;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ComprobarSecuencia(int boton)
    {
        if (generarSecuencias.puedeJugar == false)
        {
            return;
        }

        secuenciaJugador[indiceActualJugador] = boton;

        if (secuenciaJugador[indiceActualJugador] != generarSecuencias.secuencia[indiceActualJugador])
        {
            Debug.Log("Perdedor");

        }
        indiceActualJugador++;

        if (indiceActualJugador == generarSecuencias.indiceActual)
        {
            if (indiceActualJugador == secuenciaJugador.Length)
            {
                Debug.Log("He ganado");
                return;
            }
            StartCoroutine(generarSecuencias.Esperar());
            indiceActualJugador = 0;



        }
    }
    public void Perder()
    {
        indiceActualJugador = 0;
        generarSecuencias.indiceActual = 0;
        secuenciaJugador = new int[5];
        generarSecuencias.secuencia = new int[5];
        StartCoroutine(generarSecuencias.Esperar());

    }
}
