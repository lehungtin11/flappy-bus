using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveSpeed : MonoBehaviour
{
    private int moveSpeed = 10;
    private float deadZone = -50;
    private float openZone = 20;
    private float currentPosition;
    BirdScript busScript;
    // Start is called before the first frame update
    void Start()
    {
        busScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        currentPosition = transform.GetChild(1).position.y - Random.Range(5,10);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        } 

        if (transform.position.x < openZone && busScript.getBirdStatus())
        {
            if(transform.GetChild(1).position.y > currentPosition)
            {
                transform.GetChild(1).position = transform.GetChild(1).position + Vector3.down * 20 * Time.deltaTime;
            } 
        }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
