using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public float fallMultiplier;
    private void Update()
    {
        Debug.Log(rb.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, jumpForce);
        }
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Restart();
        }
        if(collision.gameObject.tag == "Score")
        {
            Debug.Log("I make a score!!!");
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
