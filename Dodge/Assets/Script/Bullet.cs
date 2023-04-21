using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag =="Player")
        {
            //����  ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();
        
            if(playerController !=null)
            {
                // ���� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
                playerController.Die();
            }
        }
    }
    void Update()
    {
    }
}
