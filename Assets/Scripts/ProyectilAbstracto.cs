using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProyectilAbstracto : MonoBehaviour {

    /*Una clase abstracta no se puede instanciar directamente y se utiliza como una clase base para otras clases.
     Un método abstracto no tiene una implementación concreta y se espera que las clases derivadas lo implementen*/
    protected abstract void Explotar();

    //protected Se puede heredar y utilizar en las clases derivadas
    protected void MatarEnemigo() {
        //Aqui pondríamos el código para matar al enemigo

        //Pero además, cuando se golpea al enemigo, el propio proyectil tiene que
        //explotar, por lo que llamamos a ese método
        Explotar();

    }
}
