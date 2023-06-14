using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horario : IComparable {
    // Enumeración de los módulos disponibles
    public enum Modulo {
        PMV,
        RVRA,
        PRIA,
        DG2D3D,
        DXPP
    }

    // Enumeración de los días de la semana
    public enum DiaSemana {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes
    }

    public Modulo modulo;  // Módulo del horario
    public DiaSemana dia;  // Día de la semana
    public int sesion;     // Número de sesión

    // Método que devuelve la información del horario
    public string Info() {
        return $"El {dia} a {sesion}ª: {modulo}";
    }

    // Implementación de la interfaz IComparable

    // Método para comparar si el horario es menor que otro horario
    public bool Menor(IComparable otro) {
        Horario horarioAComparar = otro as Horario;
        if (horarioAComparar == null) {
            return false;
        }

        return this.dia < horarioAComparar.dia || this.dia == horarioAComparar.dia && this.sesion < horarioAComparar.sesion;
    }

    // Método para comparar si el horario es igual a otro horario
    public bool Igual(IComparable otro) {
        Horario horarioAComparar = otro as Horario;
        if (horarioAComparar == null) {
            return false;
        }

        return this.dia < horarioAComparar.dia && this.sesion == horarioAComparar.sesion;
    }

    // Método para comparar si el horario es mayor que otro horario
    public bool Mayor(IComparable otro) {
        Horario horarioAComparar = otro as Horario;
        if (horarioAComparar == null) {
            return false;
        }

        return this.dia > horarioAComparar.dia || this.dia == horarioAComparar.dia && this.sesion > horarioAComparar.sesion;
    }

    // Método para comparar si el horario es mayor o igual que otro horario
    public bool MayorOIgual(IComparable otro) {
        return this.Mayor(otro) || this.Igual(otro);
    }

    // Método para comparar si el horario es menor o igual que otro horario
    public bool MenorOIgual(IComparable otro) {
        return this.Menor(otro) || this.Igual(otro);
    }
}

