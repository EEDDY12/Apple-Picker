using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public GameObject branchPrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    public float chanceToDropBranch = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        if (Random.value < chanceToDropBranch)
        {
            // Drop a branch
            GameObject branch = Instantiate<GameObject>(branchPrefab);
            Vector3 branchPosition = transform.position;
            branch.transform.position = transform.position;
            branchPosition.y = 0f; // Set the Y position to ground level
            Invoke("DropApple", secondsBetweenAppleDrops);
        }
        else
        {
            // Drop an apple
            GameObject apple = Instantiate<GameObject>(applePrefab);
            Vector3 applePosition = transform.position;

            apple.transform.position = transform.position;
            applePosition.y = 0f; // Set the Y position to ground level
            Invoke("DropApple", secondsBetweenAppleDrops);
        }
    }

    // Update is called once per frame
        void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        // else if (Random.value < chanceToChangeDirections)
        // {
        //     speed *= -1; // Change direction
        // }
    }

    void FixedUpdate()
    {
        if (Random.value < 0.1f)
        {
            speed *= -1;
        }
    }
}
