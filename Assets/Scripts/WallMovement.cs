using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float wallSpeed;
    public float destroyDelay;
    private void Start()
    {
        rb.velocity = new Vector2(-wallSpeed, 0);
        StartCoroutine(DestroyDelay());
    }
    IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(this.gameObject);
    }
}
