using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller; // A var that holds the chracter's character controller component.
    public float moveSpeed = 5f;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player movment input
        float horizontalInput = Input.GetAxis("Horizontal"); //Left and right input from player
        float verticalInput = Input. GetAxis("Vertical"); //Forward and backward input from the player
        
        //Calculate the players movement direction
        Vector3 movement = new Vector3(horizontalInput, 0,verticalInput);
        
        //Move player based on the input
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
