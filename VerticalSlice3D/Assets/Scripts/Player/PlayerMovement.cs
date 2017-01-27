using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [HideInInspector]public bool wait;
    [HideInInspector]public bool pressed;
    [HideInInspector]public bool canIUseItW;
    [HideInInspector]public bool canIUseItS;
    [HideInInspector]public bool canIUseItA;
    [HideInInspector]public bool canIUseItD;

    private Rigidbody rigid;

    [HideInInspector]public int lastHit;

    private float jump;
    private float speed;
    private float turningSpeed;

    private Vector3 curPos;
    private Vector3 nextDir;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        canIUseItW = true;
        canIUseItS = true;
        canIUseItA = true;
        canIUseItD = true;
        lastHit = 0;
        jump = 100;
        speed = 5f;
        turningSpeed = 1000;
    }

    void Update()
    {
        if (transform.position != new Vector3(curPos.x,transform.position.y,curPos.z)+ nextDir)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(curPos.x, transform.position.y, curPos.z) + nextDir, speed*Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(nextDir),turningSpeed * Time.deltaTime);
        }
        else
        {
            nextDir = Vector3.zero;
            curPos = transform.position;
            curPos.x = Mathf.Round(curPos.x);
            curPos.z = Mathf.Round(curPos.z);

            if (Input.GetKeyDown(KeyCode.W) && !wait && canIUseItW|| Input.GetKeyDown(KeyCode.UpArrow) && !wait && canIUseItW)
            {
                lastHit = 0;
                nextDir.z = Input.GetAxisRaw("Vertical");
                jumping();
            }else if (Input.GetKeyDown(KeyCode.S) && !wait && canIUseItS || Input.GetKeyDown(KeyCode.DownArrow) && !wait && canIUseItS)
            {
                lastHit = 1;
                nextDir.z = Input.GetAxisRaw("Vertical");
                jumping();
            }else if (Input.GetKeyDown(KeyCode.A) && !wait && canIUseItA || Input.GetKeyDown(KeyCode.LeftArrow) && !wait && canIUseItA)
            {
                lastHit = 2;
                nextDir.x = Input.GetAxisRaw("Horizontal");
                jumping();
            }
            else if (Input.GetKeyDown(KeyCode.D) && !wait && canIUseItD || Input.GetKeyDown(KeyCode.RightArrow) && !wait && canIUseItD)
            {
                lastHit = 3;
                nextDir.x = Input.GetAxisRaw("Horizontal");
                jumping();
            }
        }
    }

    void jumping()
    {
        rigid.AddForce(0, jump, 0);
    }
    private IEnumerator waiting()
    {
        yield return new WaitForSeconds(0.5f);
        wait = false;
        pressed = false;
        StopCoroutine(waiting());
    }
}