using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Codigo_Salud : MonoBehaviour
{

    public float Salud = 100;
    public float SaludMaxima = 100;

    [Header("Interfaz")]
    public Image BarraSalud;
    public Text TextoSalud;
    public CanvasGroup PantallaDaņo;

    [Header("Muerto")]
    public GameObject Muerto;


    void Update()
    {
        if(PantallaDaņo.alpha>0)
        {
            PantallaDaņo.alpha -= Time.deltaTime;
        }
        ActualizarInterfaz();
    }


    public void RecibirCura(float cura)
    {
        Salud += cura;

        if(Salud> SaludMaxima)
        {
            Salud= SaludMaxima;
        }
    }


    public void RecibirDaņo(float daņo)
    {
        Salud -= daņo;
        PantallaDaņo.alpha = 1;

        if(Salud<=0)
        {
            Instantiate(Muerto);
            Destroy(gameObject);
        }
    }

    void ActualizarInterfaz()
    {
        BarraSalud.fillAmount = Salud / SaludMaxima;
        TextoSalud.text = "+ " + Salud.ToString("f0");
    }


}
