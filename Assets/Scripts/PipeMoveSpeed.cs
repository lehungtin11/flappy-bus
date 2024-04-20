using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveSpeed : MonoBehaviour
{
    public int moveSpeed = 5;
    private float deadZone = -50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
