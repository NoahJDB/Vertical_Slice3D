using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement2 : MonoBehaviour
{
    private PlayerInput inputManager;
    [SerializeField]
    private float movementSpeed = 5;
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (!(inputManager = this.GetComponent<PlayerInput>()))
        {
            inputManager = this.gameObject.AddComponent<PlayerInput>();
        }
    }

    void Update()
    {
        Vector3 movement = new Vector3();
        if (inputManager.Up())
        {
            Vector3 u = new Vector3(0, 0, 1) * movementSpeed;
            this.rb.AddForce(u,ForceMode.Impulse);
            // movement += this.transform.forward;
        }
        if (inputManager.Down())
        {
            Vector3 d = new Vector3(0, 0, -1) * movementSpeed;
            this.rb.AddForce(d, ForceMode.Impulse);
            // rb.AddForce(0, -1, thrust, ForceMode.Impulse);
            // movement -= this.transform.forward;
        }
        if (inputManager.Right())
        {
            Vector3 r = new Vector3(1, 0, 0) * movementSpeed;
            this.rb.AddForce(r, ForceMode.Impulse);
            // movement += this.transform.right;
        }
        if (inputManager.Left())
        {
            Vector3 l = new Vector3(-1, 0, 0) * movementSpeed;
            this.rb.AddForce(l, ForceMode.Impulse);
            //movement -= this.transform.right;
        }
        movement.Normalize();
       //d rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        //this.transform.position += (movement * Time.deltaTime * movementSpeed);
    }
}
