using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public float jump_p;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jump_p;
        }
        /*
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.left * jump_p;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.right * jump_p;
        }*/

        if (transform.position.x < -7)
        {
            transform.position += Vector3.right/100;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "no")
        {
            BlockG.blockspeed = 3.0f;
            SceneManager.LoadScene("GameOverSC");
        }
    }
}
