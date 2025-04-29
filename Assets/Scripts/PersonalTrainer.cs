using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    int PrecioCardio = 1000;
    int PrecioFuerza = 1500;
    int PrecioRecreativo = 2500;
    
    public int HoraSemana;
    public string TipoEntrenamiento;

    float PrecioSubtotal;
    float PrecioTotal;
    // Start is called before the first frame update
    void Start()
    {
        if(HoraSemana > 6 || HoraSemana < 1)
        {
            Debug.Log("Ingresar cantidad de horas semanales válida, entre 1 y 6 horas.");
            return;
        }

        if (TipoEntrenamiento == "Cardio" && HoraSemana < 6)
        {
            PrecioTotal = PrecioCardio * HoraSemana;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        } else if (TipoEntrenamiento == "Cardio" && HoraSemana == 6)
        {
            PrecioSubtotal = PrecioCardio * HoraSemana;
            PrecioTotal = PrecioSubtotal * 0.9f;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        }
        //Fuerza

        else if (TipoEntrenamiento == "Fuerza" && HoraSemana < 6)
        {
            PrecioTotal = PrecioFuerza * HoraSemana;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        }
        else if (TipoEntrenamiento == "Fuerza" && HoraSemana == 6)
        {
            PrecioSubtotal = PrecioFuerza * HoraSemana;
            PrecioTotal = PrecioSubtotal * 0.9f;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        }
        //Recreativo

        else if (TipoEntrenamiento == "Recreativo" && HoraSemana < 6)
        {
            PrecioTotal = PrecioRecreativo * HoraSemana;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        }
        else if (TipoEntrenamiento == "Recreativo" && HoraSemana == 6)
        {
            PrecioSubtotal = PrecioRecreativo * HoraSemana;
            PrecioTotal = PrecioSubtotal * 0.9f;
            Debug.Log("Reservaste el servicio de " + TipoEntrenamiento + " con " + HoraSemana + " horas reservadas, El precio total es de " + PrecioTotal);
        }
        else
        {
            Debug.Log("Ingresar entrenamiento válido: Cardio, Fuerza o Recreativo");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
