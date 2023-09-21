using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private CharacterController _characterController;
    public float playerSpeed = 50;
    public float gravity = -9.8f;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizInp = Input.GetAxis("Horizontal");
        float vertInp = Input.GetAxis("Vertical");

        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? playerSpeed * 2.0f : playerSpeed;

        Vector3 movement = new Vector3(horizInp, 0, vertInp);
        movement = transform.TransformDirection(movement);
        movement *= currentSpeed;
        movement.y = gravity;
    
        //movement = Vector3.ClampMagnitude(movement, currentSpeed);
        
        _characterController.Move(movement*Time.deltaTime);
    }
}
