using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreCharacterController : MonoBehaviour
{

    [SerializeField] float speedMultiplier = 5f;
    float horizontalMovement;
    float verticalMovement;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        SetInput();
    }



    void SetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier;
        verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier;
    }

    void Move(Vector2 moveDirection)
    {

    }
}
