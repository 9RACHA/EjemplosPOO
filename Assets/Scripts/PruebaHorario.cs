using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PruebaHorario : MonoBehaviour {
    private List<Horario> horario = new List<Horario>();

    // Start is called before the first frame update
    void Start() {
       //Rellenamos la lista horario
        RellenarLista();

        //Y luego la imprimimos, primero desordenada
        Debug.Log("*** Lista desordenada ***");
        PrintHorario();        
        

        //Y despues ordenada

        //Horario[] arrayHorario = horario.ToArray();
        Util.OrdenarLista<Horario>(horario);
        //horario = arrayHorario.ToList();
        Debug.Log("*** Lista ordenada ***");
        PrintHorario();
    }

    private void PrintHorario() {
        //Recorremos la lista horario imprimiendo el string
        //generado llamando al método Info() de cada Horario
        foreach(Horario h in horario) {
            Debug.Log(h.Info());
        }
    }


    private void RellenarLista() {
        //Rellenamos la lista horario con varios objetos de la clase Horario
        //Cada uno de estos objetos lo generamos llamando a AddHorario
        //De forma intencionada, los horarios están desordenados
        AddHorario(Horario.DiaSemana.Lunes, 1, Horario.Modulo.PRIA);
        AddHorario(Horario.DiaSemana.Lunes, 2, Horario.Modulo.PRIA);

        AddHorario(Horario.DiaSemana.Viernes, 1, Horario.Modulo.RVRA);
        AddHorario(Horario.DiaSemana.Viernes, 2, Horario.Modulo.RVRA);
        AddHorario(Horario.DiaSemana.Viernes, 4, Horario.Modulo.RVRA);
        AddHorario(Horario.DiaSemana.Viernes, 3, Horario.Modulo.RVRA);

        AddHorario(Horario.DiaSemana.Miercoles, 4, Horario.Modulo.PMV);
        AddHorario(Horario.DiaSemana.Miercoles, 3, Horario.Modulo.PMV);

    }

    private void AddHorario(Horario.DiaSemana dia, int sesion, Horario.Modulo modulo) {
        //Creamos un objeto de la clase horario
        Horario h = new Horario();

        //Lo rellenamos con los valores recibidos como parámetros
        h.dia = dia;
        h.sesion = sesion;
        h.modulo = modulo;

        //Añadimos el horario a la lista
        horario.Add(h);
    }

}
