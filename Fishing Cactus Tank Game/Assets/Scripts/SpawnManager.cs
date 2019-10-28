using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject tankEnnemi;
    private float spawnRangeX = 2700;
    private float spawnRangeZ = 2700;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<4; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Quaternion rotationPos = new Quaternion(0, Random.Range(-180, 180), 0, Random.Range(-180, 180));
            Instantiate(tankEnnemi, spawnPos, rotationPos);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
