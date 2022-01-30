using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float playerHealth = 200f;
    [SerializeField] float playerSpeed = 1f; //controlar velocidad
    [SerializeField] Vector3 playerDirection = new Vector3(1f, 0f, 0f); //controlar direccion
    [SerializeField] float damage = 0f; //para controlar el daño desde el editor
    [SerializeField] float heal = 0f;  // Para controlar la restauracion desde el editor


    void Start()
    {
        Debug.Log("Inicio del Juego");
        Vector3 playerDirection = new Vector3(0f, 0f, 0f); //direccion inicial
        damage = 0f; //daño inicial
        heal = 0f; //restauracion inicial
    }


    void Update()
    {
        MovePlayer(playerDirection);

        Debug.Log("La vida del jugador es" + playerHealth);

        DamagePlayer(damage);

        HealPlayer(heal);


    }
    void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * playerSpeed * Time.deltaTime);
    }

    void DamagePlayer(float damageRate)

    {

        playerHealth = playerHealth - 1 * damageRate * Time.deltaTime;

    }

    void HealPlayer(float healRate)
    {

        playerHealth = playerHealth + 1 * healRate * Time.deltaTime;

    }



}
