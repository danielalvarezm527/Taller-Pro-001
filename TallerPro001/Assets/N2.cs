using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2 : MonoBehaviour
{
    Hero hero = new Hero();

    void Start()
    {
        hero.Heroes();
        int random;
        int random2 = Random.Range(4, 10);

        for (int i = 0; i < random2; i++)
        {
            random = Random.Range(0, 2);
            if (random == 0)
                new Zombie();
            else
                new Aldeano();
        }
        
    }

    public void Update()
    {
        hero.movHero();

    }

}
/// <summary>
/// En la calse aldeano se crea una primitiva tipo cubo la cual se le asigna un nombre aleatorio en un array de 20 posiciones
/// en el cual se guardan los nombres propuestos, se les da un posicion aleatoria y una edad entre 15 y 20 años.
/// </summary>
internal class Aldeano
{
    string[] nombres = new string[] { "Daniel", "Julio", "Sebastian", "Santiago", "Alex", "Danilo", "Luis", "Juan", "Anderson", "Cristian", "Alejandro", "Kevin", "Jorge", "Felipe", "David", "Natalia", "Camila", "Monica", "Andrea", "Carolina" };
    GameObject aldeano;
    public Aldeano()
    {
        aldeano = GameObject.CreatePrimitive(PrimitiveType.Cube);
        aldeano.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        aldeano.name = nombres[Random.Range(0, 20)];
        int edad = Random.Range(15, 101);

        Debug.Log("Hola soy " + aldeano.name + " Y tengo " + edad + " Años ");
    }

}
/// <summary>
/// En la clase zombie se crea una cantidad al azar de cubos que representan a los zombies, 
/// en una posicion aleatoria y 
/// se les da un color al alazar entre cyan, magenta y verde.
/// </summary>
internal class Zombie
{
    int colores = Random.Range(0, 4);

    GameObject zombie;
    public Zombie()
    {
        zombie = GameObject.CreatePrimitive(PrimitiveType.Cube);
        zombie.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        zombie.name = "Zombie";

        if (colores == 0)
        {
            zombie.GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log("Soy un zombie de color Cyan");
        }
        else if (colores == 1)
        {
            zombie.GetComponent<Renderer>().material.color = Color.magenta;
            Debug.Log("Soy un zombie de color Magenta");
        }
        else if (colores == 2)
        {
            zombie.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Soy un zombie de color Verde");
        }

    }

}
/// <summary>
/// En esta clase se crea a el Heroe, en una pisicion aleatoria, junto con el componente de la camara y su respectivo nombre.
/// </summary>
internal class Hero
{
    GameObject heroe;
    public void Heroes()
    {
        heroe = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        heroe.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        heroe.AddComponent<Camera>();
        heroe.name = "Heroe";
    }

    public void movHero()
    {
        if (Input.GetKey(KeyCode.W))
        {
            heroe.transform.Translate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            heroe.transform.Translate(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            heroe.transform.Rotate(0, -3, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            heroe.transform.Rotate(0, 3, 0);
        }

    }

}