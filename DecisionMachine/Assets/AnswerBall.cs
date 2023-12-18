using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBall : MonoBehaviour
{
  public Color color;
  public string answer;

  private void Start()
  {
    var mr = GetComponent<MeshRenderer>();
    mr.material.color = color;
  }
}
