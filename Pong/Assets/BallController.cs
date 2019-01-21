using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Pause());
    }
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.x >= 17f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        if(this.transform.position.x <= -17f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

	}

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(6f, 6f);
    }
}
