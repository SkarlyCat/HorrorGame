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
    public CanvasGroup PantallaDa�o;

    [Header("Muerto")]
    public GameObject Muerto;


    void Update()
    {
        if(PantallaDa�o.alpha>0)
        {
            PantallaDa�o.alpha -= Time.deltaTime;
        }
        ActualizarInterfaz();
    }

    public void RecibirDa�o(float da�o)
    {
        Salud -= da�o;
        PantallaDa�o.alpha = 1;

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
