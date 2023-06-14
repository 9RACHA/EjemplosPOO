using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaReferenciaValor : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int i = 4;
        Debug.Log("Valor de i " + i);
        // La función Incrementar recibe el parámetro por valor
        // por lo que la variable i no cambia
        Incrementar(i);
        Debug.Log("Valor de i incrementado " + i);

        Debug.Log("**********************************");

        Debug.Log("Valor de i " + i);
        // La función Decrementar recibe el parámetro por referencia
        // por lo que la variable i sí cambia
        Decrementar(ref i);
        Debug.Log("Valor de i decrementado " + i);

        Debug.Log("**********************************");

        // Creamos un objeto de la clase Horario y lo rellenamos de datos
        Horario horario = new Horario();
        horario.dia = Horario.DiaSemana.Lunes;
        horario.sesion = 1;
        horario.modulo = Horario.Modulo.PMV;

        Debug.Log("Valor de horario antes " + horario.Info());
        SiguienteSesion(horario);
        Debug.Log("Valor de horario después " + horario.Info());

        Debug.Log("**********************************");

        NuevaSesion(horario);
        Debug.Log("Valor de horario después de NuevaSesion " + horario.Info());

        NuevaSesionReferencia(ref horario);
        Debug.Log("Valor de horario después de NuevaSesionReferencia " + horario.Info());

        Debug.Log("**********************************");

        Horario horario2;

        NuevaSesionOut(out horario2);
        Debug.Log("Valor de horario2 después de NuevaSesionOut " + horario2.Info());
    }

    private void Incrementar(int valor) {
        valor++;
        Debug.Log("Incrementar. Valor incrementado " + valor);
    }

    private void Decrementar(ref int valor) {
        valor--;
        Debug.Log("Decrementar. Valor decrementado " + valor); 
    }

    private void SiguienteSesion(Horario h) {
        h.sesion++;
        if(h.sesion > 6) {
            h.sesion = 1;
            h.dia++;
        }
        if(h.dia > Horario.DiaSemana.Viernes) {
            h.dia =  Horario.DiaSemana.Lunes;
        }
    }

    private void NuevaSesion(Horario h) {
        h = new Horario();
        h.dia = Horario.DiaSemana.Miercoles;
        h.sesion = 6;
        h.modulo = Horario.Modulo.RVRA;
    }

    private void NuevaSesionReferencia(ref Horario h) {
        h = new Horario();
        h.dia = Horario.DiaSemana.Miercoles;
        h.sesion = 6;
        h.modulo = Horario.Modulo.RVRA;
    }

    private void NuevaSesionOut(out Horario h) {
        h = new Horario();
        h.dia = Horario.DiaSemana.Viernes;
        h.sesion = 4;
        h.modulo = Horario.Modulo.RVRA;
    }
}

