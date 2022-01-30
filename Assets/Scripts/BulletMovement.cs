using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float bulletSpeed = 1f; //controlar velocidad
    [SerializeField] Vector3 bulletDirection = new Vector3(-1f, 0f, 0f); //controlar direccion

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet(bulletDirection);
    }
    void MoveBullet(Vector3 direction)
    {
        transform.Translate(direction * bulletSpeed * Time.deltaTime);
    }
}
