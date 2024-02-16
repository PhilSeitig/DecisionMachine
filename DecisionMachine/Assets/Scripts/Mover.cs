using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  public enum MoveAxis
  {
    X,
    Y,
    Z
  }

  public MoveAxis axis = MoveAxis.X;
  public float minDelta = 0.2f;
  public float maxDelta = 0.7f;
  public float minSpeed = 0.5f;
  public float maxSpeed = 4.0f;

  private float delta;
  private float speed;

  private void Start()
  {
    delta = Random.Range(minDelta, maxDelta);
    speed = Random.Range(minSpeed, maxSpeed);

    //var mr = GetComponent<MeshRenderer>();
    //if (mr != null)
      //mr.material.color = Color.blue;
  }

  private void Update()
  {
    Vector3 moveVector = Vector3.zero;
    if (axis == MoveAxis.X)
      moveVector = Vector3.right;
    else if (axis == MoveAxis.Y)
      moveVector = Vector3.up;
    else if (axis == MoveAxis.Z)
      moveVector = Vector3.forward;

    transform.position += moveVector * delta * Mathf.Sin(Time.time) * speed * Time.deltaTime;
  }
}
