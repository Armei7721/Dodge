using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //탄알 이동 속력
    private Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        //충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if(other.tag =="Player")
        {
            //상대방  오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();
        
            if(playerController !=null)
            {
                // 상대방 PlayerController 컴포넌트를 가져오는 데 성공했다면
                playerController.Die();
            }
        }
    }
    void Update()
    {
    }
}
