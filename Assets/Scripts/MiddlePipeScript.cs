using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    MusicManager musicManager;
    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<MusicManager>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.updateScore(1);
            musicManager.PlaySFX(musicManager.point);
        }
    }
}
