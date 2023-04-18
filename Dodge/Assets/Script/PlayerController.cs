using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵� �ӷ�

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)==true)
        {   //���� ����Ű �Է��� ������ ��� z �������� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        else if(Input.GetKey(KeyCode.DownArrow)==true)
        {   //�Ʒ��� ����Ű �Է��� ������ ��� -z �������� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)==true)
        {   //���� ����Ű �Է��� ������ ��� -x �������� ���ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        else if(Input.GetKey(KeyCode.RightArrow)==true)
        {   //������ ����Ű �Է��� ������ ��� x �������� ���ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}