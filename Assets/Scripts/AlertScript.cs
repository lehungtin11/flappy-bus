using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertScript : MonoBehaviour
{
    private float remainingTime = 2;

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        } else if (remainingTime < 0)
        {
            remainingTime = 2;
            gameObject.SetActive(false);
        }

        //int minutes = Mathf.FloorToInt(remainingTime / 60);
        //int seconds = Mathf.FloorToInt(remainingTime % 60);
    }
}
