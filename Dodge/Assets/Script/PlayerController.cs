using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동 속력

    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)==true)
        {   //위쪽 방향키 입력이 감지된 경우 z 방향으로 힘주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        else if(Input.GetKey(KeyCode.DownArrow)==true)
        {   //아래쪽 방향키 입력이 감지된 경우 -z 방향으로 힘주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)==true)
        {   //왼쪽 방향키 입력이 감지된 경우 -x 방향으로 힘주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        else if(Input.GetKey(KeyCode.RightArrow)==true)
        {   //오른쪽 방향키 입력이 감지된 경우 x 방향으로 힘주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}