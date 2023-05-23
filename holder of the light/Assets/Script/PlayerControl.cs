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
        // Bepaal de bewegingsrichting op basis van de input van de speler
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        moveAmount = moveDir * moveSpeed * Time.deltaTime;

        // Bepaal de richting waarin de speler moet draaien
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
        // Versnellen als de speler de linker shift-toets ingedrukt houdt
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveAmount = moveDir * sprintSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        // Beweeg de speler op basis van de berekende bewegingshoeveelheid
        rb.MovePosition(rb.position + moveAmount);
        // Toepassen van de valversnelling als de speler niet op de grond staat
        if (!isGround)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * Fallmultiplier * Time.deltaTime;  
        }

        // Raycast om te detecteren of de speler op een bewegend platform staat
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

    /*private void OnDrawGizmos()                // Gizmos uittekenen
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(transform.position, transform.position - (transform.up * 0.6f));
    }*/
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "GameOver")   // eind punt,als de player aangeraakt
        {
            GameEnd.isGameOver = true;       //GameEnd script
            Debug.Log("xixixixi");
        }
    }
}
