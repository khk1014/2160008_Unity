using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     * Start �޼ҵ�
     *   �̸� ���ǵ� Ư�� �̺�Ʈ �Լ�(�޼ҵ�)�ν�, �� Ư�� �Լ����� C#������ �Լ��� �޼ҵ��� ��
     *   MonoBehaviour Ŭ������ �ʱ�ȭ �� �� ȣ�� �Ǵ� �̺�Ʈ �Լ�
     *   ���α׷���  ������ �� �� ���� ȣ���� �Ǵ� �Լ��� ���� ������Ʈ�� �޾ƿ��ų� ������Ʈ�� �ٸ� �Լ����� ����ϱ� ���� �ʱ�ȭ ���ִ� ���
     *   ��, Start() �޼���� ��ũ��Ʈ �ν��Ͻ��� Ȱ��ȭ�� ��쿡�� ù ��° ������ ������Ʈ ���� ȣ���ϹǷ� �ѹ��� ����
     *   �� ���¿� ���Ե� ��� ������Ʈ�� ���� Update �� ������ ȣ��� ��� ��ũ��Ʈ�� ���� Start �Լ��� ȣ��
     *   ���� �����÷��� ���� ������Ʈ�� �ν��Ͻ�ȭ�� ���� ������� ����
     */

    // �ɹ� ���� ����
    float fMaxPositionX = 10.0f;  // �÷��̾ ��, �� �̵��� ����â�� ����� �ʵ��� Vector �ִ� ���� ����
    float fMinPositionX = -10.0f; // �÷��̾ ��, �� �̵��� ����â�� ����� �ʵ��� Vector �ּڰ� ���� ����
    float fPositionX = 0.0f;     // �÷��̾ ��, �� �̵��� �� �ִ� X ��ǥ ���� ����


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* 
        * ����̽� ���ɿ� ���� ���� ����� ���� ���ֱ�
        *   � ������ ��ǻ�Ϳ��� �����ص� ���� �ӵ��� �����̵��� �ϴ� ó��
        *   ����Ʈ���� 60, ����� PC�� 300�� �� �� �ִ� ����̽� ���ɿ� ���� ���� ���ۿ� ������ ��ĥ �� ����
        *   �����ӷ���Ʈ�� 60���� ����
        */

        Application.targetFrameRate = 60;
    }

    /*
     * Update �޼���
     *   �� ������ ���� ȣ���� �Ǵ� �Լ��� �ڽ��� ��ǻ�Ͱ� 60 �������̶�� �ʴ� 60�� ������ �Ǵ� �Լ�
     *   ���� ���࿡ �ʿ��� �Լ����� update() �Լ����� �����ϵ��� �ڵ� ��
     *   �����Ӵ� 1ȸ ȣ����
     *   �ұ�Ģ������ ������(�������� �浹�˻� ���� ����� �ȵ� �� ����)
     *   �ַ� �ܼ��� Ÿ�̸�, Ű �Է��� ���� �� �����
     */


    // Update is called once per frame
    void Update()
    {
        /*
         *  Ű�� �������� �����ϱ� ���ؼ��� Input Ŭ������ GetKeyDown �޼��带 �����
         *  �� �޼���� �Ű������� ������ Ű�� ������ ���� true�� �� �� ��ȯ
         *  GetKeyDown �޼���� ���ݱ��� ����ϴ� GetMouseButtonDown �޼���� ����ϹǷ� ���� ������ �� ���� ��
         *  Ű�� ���� ���� : GetKeyDown()
         *  Ű�� ������ �ִ� ���� : GetKey()
         *  Ű�� �����ٰ� �� ���� : GetKeyUp()
         */

        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);  // �������� '2'��ŭ �̵�
        }
        // ������ ȭ��ǥ�� ������ ��-> GetKeyDown(KeyCode.RightArrow)
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);   // ���������� '2'��ŭ �̵�
        }

        /*
        * Mathf.Clamp(value, min, max) �޼���
        *  Ư�� ���� ��� ������ ���ѽ�Ű���� �� �� ����ϴ� �޼���
        *  value ���� ���� : min <= value <= max
        *  �ּ�/�ִ밪�� �����Ͽ� ������ ���� �̿ܿ� ���� ���� �ʵ��� �� �� ���
        *  �÷��̾ ������ �� �ִ� �ּ�(fMinPositionX)/�ִ�(fMaxPositionX) �������� �����Ͽ� �� ������ ����� �ʵ����Ѵ�.
        */

        fPositionX = Mathf.Clamp(transform.position.x, fMinPositionX, fMaxPositionX);
        transform.position = new Vector3(fPositionX, transform.position.y, transform.position.z);
    }
}