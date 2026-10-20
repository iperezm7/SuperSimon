using UnityEngine;

public class boton : MonoBehaviour
{
    public GameManager gamemanager;
    public void PulsarBoton(int boton)
    {
        gamemanager.ComprobarSecuencia(boton);
    }
}
