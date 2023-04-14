using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    void LateUpdate()
    {
        
        
            transform.position = new Vector3(0f, target.position.y, transform.position.z);

        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
