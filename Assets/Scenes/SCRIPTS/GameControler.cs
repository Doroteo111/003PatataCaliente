using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



public class GameControler : MonoBehaviour
{

    private int randomNumber;
    public int clickCounter;         //cada vez que llame a la función contará la variable


    void Start()
    {
        randomNumber = Random.Range(1, 11);         //11 para incluir hasta el 10
    }

    private void Update()  //si hago click llama a la función de AddOne...
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }
        if (Input.GetKeyDown(KeyCode.Return))  //al pulsar el ENTER se activa la función + resultado
        {
            if (HaveIWon())
            {
                Debug.Log("¡Eres un grandeee!");
            }
        }
    }
    private void AddOneToCounter()      //global
    {
        clickCounter++;
        transform.localScale += Vector3.one;   //cada click (asignado a la bola) crecera
    }
    private bool HaveIWon()
    {
        if (clickCounter < randomNumber)
        {
            Debug.Log($"Has hecho {clickCounter} clicks y el número aleatorio era {randomNumber}");
            return false;
        } else if (clickCounter ==randomNumber)
        {
            Debug.Log("¡Has ganado!");
            return true;
        }

        Debug.Log("Te has pasado chaval...");
        Destroy(gameObject);          //destruir un game object
        return false;
    }
}
