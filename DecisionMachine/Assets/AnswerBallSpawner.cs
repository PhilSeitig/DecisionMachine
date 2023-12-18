using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int maxAmountOfBalls = 8;
    public float spawnPropability = 0.98f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateAnswerBalls(maxAmountOfBalls);
    }

    private void GenerateAnswerBalls(int amountOfBalls)
    {
        var collider = GetComponent<BoxCollider>();
        for (int i = 0; i < amountOfBalls; i++)
        {
            var ball = Instantiate(ballPrefab);

            Vector3 center = collider.bounds.center;
            Vector3 extents = collider.bounds.extents;
            //Debug.Log("center: " + center);
            //Debug.Log("extents: " + extents);

            float x = center.x + Random.Range(-extents.x, extents.x);
            float y = center.y + Random.Range(-extents.y, extents.y);
            float z = center.z + Random.Range(-extents.z, extents.z);

            Vector3 position = new Vector3(x, y, z);
            ball.transform.position = position;

            var answer = ball.GetComponent<AnswerBall>();
            //answer.color = Random.ColorHSV();
            answer.answer = "Ball No. " + (i + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float value = Random.Range(0.0f, 1.0f);
        Debug.Log(value);
        if (value > spawnPropability)
        {
            int amountOfBalls = Random.Range(0, maxAmountOfBalls) + 1;
            GenerateAnswerBalls(amountOfBalls);
        }
    }
}
