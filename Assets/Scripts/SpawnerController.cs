using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireRate = 2f;
    [SerializeField] float loadTime = 2f;
    void Start()
    {
        InvokeRepeating("BulletSpawn", loadTime, fireRate);
    }

    void Update()
    {

    }

    private void BulletSpawn()
    {
        Instantiate(bulletPrefab, transform);
    }

    // Update is called once per frame

}
