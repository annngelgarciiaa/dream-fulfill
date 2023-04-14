using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public GameObject ObjetoAmover;
    public Transform EndPoint;
    public float speed;
    private Vector3 MoverHacia;

    // Start is called before the first frame update
    void Start()
    {
        MoverHacia = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, speed * Time.deltaTime);
        if (ObjetoAmover.transform.position == EndPoint.position)
        {
            MoverHacia = StarPoint.position;
        }
        if (ObjetoAmover.transform.position == StarPoit.position)
        {
            MoverHacia = EndPoint.position;
        }

    }
}
