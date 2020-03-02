using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

    public GameObject mouse;
    public GameObject scoreText;
    public GameObject livesText;

    public float launchForce;
    public int livesRemaining;
    public bool launched = false;

    Rigidbody rigid;

    MousePosition mousePos;
    Scoring score;
    Lives lives;
    Change_Scenes change;

	// Use this for initialization
	void Start () {

        livesRemaining = 3;

        scoreText = GameObject.Find("Score");        
        score = scoreText.gameObject.GetComponent<Scoring>();

        livesText = GameObject.Find("Lives");
        lives = livesText.gameObject.GetComponent<Lives>();

        mousePos = new MousePosition();

        change = new Change_Scenes();

        Launch();
		
	}

    void Launch()
    {

        if(launched == false)
        {
            launched = true;

            rigid = GetComponent<Rigidbody>();

            CalculatedFiring calcFire = new CalculatedFiring();

            Vector3 targetVect = calcFire.CalculateFiringSolution(transform.position, mouse.transform.position, launchForce, Physics.gravity);

            if (targetVect != Vector3.zero)
            {

                rigid.AddForce(targetVect.normalized * launchForce, ForceMode.VelocityChange);

            }
        }      
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(livesRemaining > 0)
        {

            if (collision.gameObject.tag.ToString() == "Basket")
            {

                launched = false;

                score.IncrementScore();

                rigid.velocity = new Vector3(0, 0, 0);
                rigid.gameObject.transform.localPosition = new Vector3(0f, 1.5f, 80f);

                NewPos();
                Launch();

            }

            if (collision.gameObject.tag.ToString() == "Platform" && livesRemaining > 1)
            {

                launched = false;

                livesRemaining--;
                lives.DecreaseLives();

                rigid.velocity = new Vector3(0, 0, 0);
                rigid.gameObject.transform.localPosition = new Vector3(0f, 1.5f, 80f);

                NewPos();
                Launch();

            }

            else if (collision.gameObject.tag.ToString() == "Platform" && livesRemaining <= 1)
            {

                livesRemaining--;
                lives.DecreaseLives();

                score.GameOver();
                Invoke("EndLevel", 4);

            }
        }        
    }

    private void NewPos()
    {

        mousePos.NewMousePos(mouse);

    }

    private void EndLevel()
    {

        change.changeScenes(0);

    }
}