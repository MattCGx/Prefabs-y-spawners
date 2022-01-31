using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatillo : MonoBehaviour
{
    [SerializeField] GameObject doublebulletPrefab;
    [SerializeField] GameObject tripleBulletPrefab;
    [SerializeField] GameObject cuadrupleBulletPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j")){ BulletSpawn(doublebulletPrefab); };
        if (Input.GetKeyDown("k")){ BulletSpawn(tripleBulletPrefab); };
        if (Input.GetKeyDown("l")){ BulletSpawn(cuadrupleBulletPrefab); };
    }

    private void BulletSpawn(GameObject bulletType)
    {
    Instantiate(bulletType, transform);

    }
}
