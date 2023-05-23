using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl pC;
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpSpeed;
    public float sprintSpeed;
    public float Fallmultiplier;

    public bool isGround = true; //of het object op de ground staat
    public bool isDoubleJump = false;
    private bool isJump = true;
    private Vector3 movingPlatformPos;
    Vector3 moveAmount;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        if(pC == null)
        {
            pC = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        moveAmount = moveDir * moveSpeed * Time.deltaTime;

        Vector3 targetDir = Vector3.Slerp(transform.forward, moveDir, rotateSpeed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(targetDir);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGround)
            {
                rb.AddForce(Vector3.up * jumpSpeed);
                isJump = true; //object springt
                isGround = false; // is niet op de ground
            }
            else if (isDoubleJump && !isGround && isJump) // als het object dubbel kan springen && niet op de ground && object springt
            {
                rb.AddForce(Vector3.up * jumpSpeed);

                isJump = false;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveAmount = moveDir * sprintSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount);
        if (!isGround)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;  
        }

        RaycastHit hit;
            if(Physics.Raycast(transform.position, -transform.up, out hit, 0.6f))
            {
               // Debug.Log(hit.transform.name);
                if (hit.transform.gameObject.layer == 6)
                {
                    Debug.Log("We moven");
                if (movingPlatformPos == Vector3.zero)
                {
                    movingPlatformPos = hit.transform.position;
                }
                    rb.MovePosition(rb.position + (hit.transform.position - movingPlatformPos));
                    movingPlatformPos = hit.transform.position;
                }
                else
                {
                    movingPlatformPos = Vector3.zero;
                }

                if(hit.transform.gameObject.tag == "ground")
                {
                    isGround = true;
                }

        }
        else
        {
            isGround = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position - (transform.up * 0.6f));
    }
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "GameOver")
        {

            GameEnd.isGameOver = true;
            Debug.Log("xixixixi");
        }
    }
}
