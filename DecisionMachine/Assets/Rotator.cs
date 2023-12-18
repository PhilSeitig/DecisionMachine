using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Mover;

public class Rotator : MonoBehaviour
{
  public enum RotationAxis
  {
    X,
    Y,
    Z
  }

  public RotationAxis axis = RotationAxis.Y;
  public float minSpeed = 2.0f;
  public float maxSpeed = 4.0f;

  private float speed;

  private void Start()
  {
    speed = Random.Range(minSpeed, maxSpeed);

    var mr = GetComponent<MeshRenderer>();
    if (mr != null)
      mr.material.color = Color.green;
  }

  private void Update()
  {
    Vector3 rotationVector = Vector3.zero;
    if (axis == RotationAxis.X)
      rotationVector = Vector3.right;
    else if (axis == RotationAxis.Y)
      rotationVector = Vector3.up;
    else if (axis == RotationAxis.Z)
      rotationVector = Vector3.forward;

    transform.Rotate(rotationVector, speed * Time.deltaTime, Space.Self);
  }
}
