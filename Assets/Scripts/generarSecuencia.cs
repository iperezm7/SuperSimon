using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GenerarSecuencias : MonoBehaviour
{
    [SerializeField] Button[] botones;
    [SerializeField] public int[] secuencia = {0, 0, 0, 0, 0, 0};
    [SerializeField] public int indiceActual;
    [SerializeField] public bool puedeJugar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
   public IEnumerator Esperar()
    { 
        puedeJugar = false;
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].interactable = false;
        }
        int numero = Random.Range(0, botones.Length);
        secuencia[indiceActual] = numero;
        for(int i = 0;i <= indiceActual; i++)
        {
            botones[secuencia[i]].interactable = true;
            yield return new WaitForSeconds(1f);
            botones[secuencia[i]].interactable = false;
            if(i != indiceActual)
            {
                yield return new WaitForSeconds(1f);
            }
        }
        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].interactable = true;
        }
        indiceActual++;
        puedeJugar = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
