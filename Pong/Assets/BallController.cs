using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    private Rigidbody2D rb;

    public GameObject Bat1;
    public GameObject Bat2;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        Bat1 = GameObject.Find("Bat_1");
        Bat2 = GameObject.Find("Bat_2");

        StartCoroutine(Pause());
    }
	
	// Update is called once per frame
	void Update () {
        if(Mathf.Abs(this.transform.position.x) >= 21f)
        {
            Count_Score.canAddScore = true;
            this.transform.position = new Vector3(0f, 0f, 0f);
            // After ball exits screen or hits 'walls' pause upon restart
            StartCoroutine(Pause());
        }
	}

    IEnumerator Pause()
    {
        // Code to generate a number to shoot the ball in a random direction
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if (directionX == 0)
            directionX = 1;


        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(12f * directionX, 10f * directionY);
    }

    // Function to modify ball movement based on how it hits the bat
    void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.name == "Bat_1")
        {
            // Check velocity 
            if(Bat1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                // move left
                rb.velocity = new Vector2(-10f, 10f);
            }
            else if(Bat1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                // move right
                rb.velocity = new Vector2(10f, -10f);
            }
            else
            {
                // stay still
                rb.velocity = new Vector2(14f, 0f);
            }
        }
        if (hit.gameObject.name == "Bat_2")
        {
            // Check velocity 
            if (Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                // move left
                rb.velocity = new Vector2(-10f, 10f);
            }
            else if (Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                // move right
                rb.velocity = new Vector2(-10f, -10f);
            }
            else
            {
                // stay still
                rb.velocity = new Vector2(-14f, 0f);
            }
        }
    }
}
