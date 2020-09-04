using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    float timeToSpawn = 2,spawnerTimer;
    [SerializeField]
    GameObject spawnProjectile;
    // Update is called once per frame
    void Update()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        spawnerTimer += Time.deltaTime;
        if (spawnerTimer > timeToSpawn)
        {
            spawnerTimer = 0;
            GameObject projectile = Instantiate(spawnProjectile,new Vector3(Random.Range(-2,2),gameObject.transform.position.y,0),new Quaternion(0,0,0,1)) as GameObject;
            Rigidbody rig = projectile.GetComponent<Rigidbody>();
            rig.AddForce(Vector3.up * Random.Range(10,15),ForceMode.Impulse);
        }
    }
}
