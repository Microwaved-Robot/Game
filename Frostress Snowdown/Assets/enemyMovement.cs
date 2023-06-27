using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = LevelManager.main.path[pathIndex];

        // Makes the speed in seconds
        moveSpeed = moveSpeed * Time.deltaTime;

        // Move enemy towards target
        if(transform.position != target.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed);
        } else
        {
            pathIndex++;
        }
    }
}
