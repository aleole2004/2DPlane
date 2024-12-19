using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plane : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float xMin, xMax, yMin, yMax;
    private Vector2 movementInput;
    private Vector2 clampPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Porque no puedo sumar Vector2 value directamente a transform.position?
        clampPos = transform.position + new Vector3 (movementInput.x, movementInput. y, 0) * movementSpeed * Time.deltaTime;
        clampPos.x = Mathf.Clamp(clampPos.x, xMin, xMax);
        clampPos.y = Mathf.Clamp(clampPos.y, yMin, yMax);
        transform.position = clampPos;
    }
    private void OnMovement (InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }
}
