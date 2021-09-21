using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesyoperadores : MonoBehaviour

//donde pone "variables y operadores" por defecto pone "NewBehaviourScript" o el primer nombre que le pusieramos al archivo al crearlo (!!)
//deberemos cambiarlo al nombre actual del archivo si queremos que funcione

{
    public string myName;

    //Esta variable lo que hace es crear un campo de texto editable en Unity. En este caso ese campo se denominará "myName"
    //Al ser Public Unity tendrá acceso a este campo y pòdrá ser editado ahí. Si no queremos que Unity tenga acceso usaríamos "Private"
    //Otra de las variables a las que Unity tiene acceso es "SerializeField"
    //file:///C:/Program%20Files/Unity/Hub/Editor/2020.3.1f1/Editor/Data/Documentation/en/Manual/VariablesAndTheInspector.html

    private int numeros_enteros; //Números enteros, sin decimales
    private float numeros_decimales; //Números con/que admiten decimales
    private bool boleana; //True or false
    private string cadena_de_texto; //Cadena de texto

    public bool acaso_esto_funciona; //boleana pública, nos pondrá una casilla en la caja de unity que si está marcada antes de lanzar el juego nos devolverá una respuesta "true"

   



           //comparaciones
    
    public float cifraPublica;
  //float cifra = 5f;
    float Limite_Superior_De_Cifra = 10f;
    float Limite_Inferior_De_Cifra = 0f;

    



    // Start is called before the first frame update
    void Start()
    {
        print("hello");  //print manda un texto a la consola, y es nativo de C#.No debe ir en Update si no queremos tener mensajes infinitos
        Debug.Log("I am alive!"); //Debug.Log hace lo mismo, pero es propio de Unity. 

        Debug.Log("I am alive and my name is " + myName); //debido a que creamos la variable pública "myname", el texto va a ser lo naranja + myName

        print(acaso_esto_funciona + " :)"); //si la variable "acaso_esto_funciona" esta marcado en la caja de unity, no dará el valor True y ff

    }

    void Comparaciones(float cifra) //Por convencion, los métodos y clases empiezan con mayuscula y camelcase esta bien tambien
     {

        
        // == igual que
        // != diferente que
        // <menor que
        // > mayor que
        // <= menor o igual que
        // >= mayor o igual que
        // && poner varias condiciones en el else y en el while, que se tienen que dar todas
        // || "or" quiero que se de o una condición o la otra

        //si "cifra" es menor que 10...
        if (cifra < Limite_Superior_De_Cifra)
        {
            // ... haz esto.
            print("Es menor que 10");
        }

        //si "cifra" es menor que Limite_Inferior_De_Cifra...
        else if (cifra > Limite_Inferior_De_Cifra)
        {
            // ... haz esto.
            print("Es mayor que 0");
        }

        //si no lo es, pero "cifra" es superior a Limite_Inferior_De_Cifra
        else if (cifra < Limite_Inferior_De_Cifra)
        {
            // ... haz esto.
            print("Es menor que 10 pero mayor que 0");
        }

        //si no es ninguna de las opciones anteriores...
        else
        {
            // ... haz esto.
            print("Es mayor que 10 :)");
        }




     }

           // Update se ejecuta/es llamado una vez por frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Comparaciones(cifraPublica);
    }
}
    