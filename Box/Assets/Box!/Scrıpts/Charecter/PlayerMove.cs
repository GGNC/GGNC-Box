using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    public float speed = 25f;
    public float ScreenWidth;
    public int GO = 0;
    public GameObject Trans;
 
    

    private void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        ScreenWidth = Screen.width;
        Invoke("Transation", 3.5f);

    }
    private void FixedUpdate()
    {
        int i = 0;
        if (GO == 0)
        {

        }
        else
        {
            if (rb.velocity.z < 20)
            { rb.AddForce(0, 0, 15); }
            else
            {

            }
            while (i < Input.touchCount)
            {
                if (Input.GetTouch(i).position.x > ScreenWidth / 2)
                {
                    MoveCharacter(0.3f);
                }
                if (Input.GetTouch(i).position.x < ScreenWidth / 2)
                {
                    MoveCharacter(-0.3f);
                }
                i++;
            }

            float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + Vector3.right * x);


            if (player.transform.position.x < -3.99 || player.transform.position.x > 3.99)
            {
                player.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
    private void MoveCharacter(float HorizontalInput)
    {
        rb.MovePosition(rb.position + Vector3.right*HorizontalInput );
    }
    private void Transation()
    {
        Trans.SetActive(false);
        GO = 1;
    }
}
