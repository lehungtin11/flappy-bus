using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myBody;
    public int velocity = 10;
    public LogicScript logic;
    private bool isBirdAlive = true;
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
        // Flap Event
        if(Input.GetKeyDown(KeyCode.Space) && isBirdAlive && !logic.isPause)
        {
            myBody.velocity = Vector2.up * velocity;
            musicManager.PlaySFX(musicManager.flap);
        }

        // Check if out-off screen
        if((transform.position.y < -20 || transform.position.y > 20) && isBirdAlive)
        {
            isBirdAlive = false;
            logic.gameOverScreen();
            musicManager.PlaySFX(musicManager.die);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isBirdAlive)
        {
            isBirdAlive = false;
            logic.gameOverScreen();
            musicManager.PlaySFX(musicManager.hit);
        }
    }
}
