using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnswerTrigger : MonoBehaviour
{
    public UnityEvent<string> onAnswerDropped = new UnityEvent<string>();

    private void OnTriggerEnter(Collider other)
    {
        var ball = other.GetComponent<AnswerBall>();
        if (ball != null)
        {
            Debug.Log("Ball dropped: " + ball.answer);

            onAnswerDropped.Invoke(ball.answer);
            Destroy(ball.gameObject);
        }
    }
}
