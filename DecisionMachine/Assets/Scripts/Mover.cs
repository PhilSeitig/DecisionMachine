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
  
  // Min and max Values for moving objects
  public MoveAxis axis = MoveAxis.X;
  public float minDelta = 0.2f;
  public float maxDelta = 0.7f;
  public float minSpeed = 0.5f;
  public float maxSpeed = 4.0f;

  private float delta;
  private float speed;

  // Set value random
  private void Start()
  {
    delta = Random.Range(minDelta, maxDelta);
    speed = Random.Range(minSpeed, maxSpeed);
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
