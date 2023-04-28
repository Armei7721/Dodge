using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
     private Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵� �ӷ�

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //    if (Input.GetKey(KeyCode.UpArrow)==true)
        //    {   //���� ����Ű �Է��� ������ ��� z �������� ���ֱ�
        //        playerRigidbody.AddForce(0f, 0f, speed);
        //    }
        //    else if(Input.GetKey(KeyCode.DownArrow)==true)
        //    {   //�Ʒ��� ����Ű �Է��� ������ ��� -z �������� ���ֱ�
        //        playerRigidbody.AddForce(0f, 0f, -speed);
        //    }
        //    else if(Input.GetKey(KeyCode.LeftArrow)==true)
        //    {   //���� ����Ű �Է��� ������ ��� -x �������� ���ֱ�
        //        playerRigidbody.AddForce(-speed, 0f, 0f);
        //    }
        //    else if(Input.GetKey(KeyCode.RightArrow)==true)
        //    {   //������ ����Ű �Է��� ������ ��� x �������� ���ֱ�
        //        playerRigidbody.AddForce(speed, 0f, 0f);
        //    }

        // ������� �������� �Է°��� �����Ͽ� ����
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = x * speed;
        float zSpeed = z * speed;

        //Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        float dash = speed;
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;

        
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 dashpower = new Vector3(newVelocity.x,0, newVelocity.z);
            playerRigidbody.AddForce(dashpower, ForceMode.VelocityChange);
       
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}