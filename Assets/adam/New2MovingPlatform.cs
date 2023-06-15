using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New2MovingPlatform : MonoBehaviour
{
    public Transform waypoint1, waypoint2;
    public int Speed;
    Vector2 targetpoint;

    // Start is called before the first frame update
    void Start()
    {
        targetpoint = waypoint2.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, waypoint1.position) < .1f) targetpoint = waypoint2.position;

        if (Vector2.Distance(transform.position, waypoint2.position) < .1f) targetpoint = waypoint1.position;

       transform.position = Vector2.MoveTowards(transform.position, targetpoint, Speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(transform , true);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
