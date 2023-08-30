using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 7f;
    private float rotateSpeed = 10f;
    private bool isWalking;
    [SerializeField] GameInput gameInput;
    private void Update()
    {
        Vector2 vel = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(vel.x, 0f, vel.y);
        transform.position += moveDir * speed * Time.deltaTime;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
        isWalking = moveDir != Vector3.zero;
    }
    public bool IsWalking()
    {
        return isWalking;
    }
}
