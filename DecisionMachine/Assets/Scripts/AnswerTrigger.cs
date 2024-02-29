using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class AnswerTrigger : MonoBehaviour
{
    // Input Canvas and Text (TMP)
    public GameObject ui;
    public TextMeshProUGUI text;

    // Get Value of AnswerBall and open Canvas
    private void OnTriggerEnter(Collider other)
    {
        var ball = other.GetComponent<AnswerBall>();
        ui.SetActive(true);
        text.SetText("Your Answer Is: " + ball.answer);
        Time.timeScale = 0;
    }
    
    private void Start()
    {
        Time.timeScale = 1;
    }
}
