using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject bothWall;
    public float area;
    public float timeDelay;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(timeDelay);
        SpwanObject();
    }
    void SpwanObject()
    {
        GameObject Wall = Instantiate(bothWall);
        Wall.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(area, -area));
        StartCoroutine(MyCoroutine());
    }
}
