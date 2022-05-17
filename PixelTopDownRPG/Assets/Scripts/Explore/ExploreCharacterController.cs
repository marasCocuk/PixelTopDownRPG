using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreCharacterController : MonoBehaviour
{
    [SerializeField] private float speedMultiplier = 5f;
    private float horizontalMovement;
    private float verticalMovement;
    private Rigidbody2D rigidbody2;

    private void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        SetInput();
        Move(horizontalMovement, verticalMovement);
    }

    private void SetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier;
        verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier;
    }

    private void Move(float xMovement, float yMovement)
    {
        Vector2 pos = rigidbody2.position;
        pos.x += xMovement;
        pos.y += yMovement;
        rigidbody2.position = pos;
    }

    private void Move(Vector2 moveDirection)
    {
        Move(moveDirection.x, moveDirection.y);
    }
}