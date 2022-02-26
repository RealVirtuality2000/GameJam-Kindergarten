using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Transform cam;
    private Vector2 turn;


    public float speed = PlayerStats.speed;

    public float smooth_time = 0.3f;
    float turnSmoothVelocity;

    private void Awake()
    {
        GameStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
        cam = FindObjectOfType<Camera>().transform;
        Debug.Log(cam);
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }

    //public float speed = 3f;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        if (direction.magnitude >= 0.1f)
        {
            
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smooth_time);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 move_dir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(move_dir.normalized * speed * Time.deltaTime);
            
        }

        //transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        //turn.x += Input.GetAxis("Mouse X");
        //turn.y += Input.GetAxis("Mouse Y");
        //transform.localRotation = Quaternion.Euler(0f, turn.x, 0f);
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }
}
