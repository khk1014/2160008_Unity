/*
  ȭ�� ������Ʈ�� 1�ʿ� �� ���� �����ϴ� �˰���
 - Update �޼���� �����Ӹ��� ����ǰ� �� �����Ӱ� ���� ������ ������ �ð� ���̴� Time.deltaTime�� ����
 - �����Ӱ� ������ ������ �ð� ���̸� �볪�� ��(delta����)�� ������(�հ�) 1�� �̻��� �Ǹ� �볪�� ���� ���
 - �볪�� ���� ���� ������ 1�ʿ� �� ���� ȭ���� ������
 - Instantiate �޼���
   -- ������ �����ϴ� ���߿� ���ӿ�����Ʈ�� ������ �� ����
   -- ȭ�� �������� �̿��Ͽ�, ȭ�� �ν��Ͻ��� �����ϴ� �޼���
 - Random.Range �޼���
 */

using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject gArrowPrefab = null;  // ȭ�� �������� ���� �������Ʈ ���� ����

    GameObject gArrowInstance = null;       // ȭ�� �ν��Ͻ� ���� ����

    float fArrowCreateSpen = 0.5f;          // ȭ���� ���� ���� : ȭ���� 1�ʸ��� ���� ����
    float fDeltaTime = 0.0f;                // �� �����Ӱ� ���� ������ ������ �ð� ���̸� �����ϴ� ����

    int nArrowPositionRange = 0;            // ȭ���� X ��ǥ Range ���� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fDeltaTime += Time.deltaTime;

        if(fDeltaTime > fArrowCreateSpen)
        {
            fDeltaTime = 0.0f;

            gArrowInstance = Instantiate(gArrowPrefab);

            nArrowPositionRange = Random.Range(-6, 7);

            gArrowInstance.transform.position = new Vector3(nArrowPositionRange, 7, 0);

        }

    }
}
