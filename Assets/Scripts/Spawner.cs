using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(2, 5);
        Instantiate(spawnerPlatforms[random], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
