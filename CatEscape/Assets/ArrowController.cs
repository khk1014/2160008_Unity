// ȭ���� ������ �Ʒ��� 1�ʿ� �ϳ��� �������� ��� --> transform.Translate()
// ȭ���� ����ȭ�� ������ ������ ȭ�� ������Ʈ�� �Ҹ��Ű�� ��� --> Destroy()

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // ������� ����
    GameObject gPlayer = null; // Player Object�� ������ GameObject ����, GameObject ������ �ʱ갪�� null

    Vector2 vArrowCirclePoint = Vector2.zero; // ȭ���� �ѷ��� ���� �߽� ��ǥ
    Vector2 vPlayerCirclePoint = Vector2.zero; // �÷��̾ �ѷ��� ���� �߽� ��ǥ
    Vector2 vArrowPlayerDir = Vector2.zero; // ȭ�쿡�� �÷��̾������ ���Ͱ�

    float fArrowRadius = 0.5f;          // ȭ�� ���� ������ 0.5
    float fPlayerRadius = 1.0f;         // �÷��̾� ���� ������ 1.0
    float fArrowPlayerDistance = 0.0f;  // ȭ���� �߽�(vArrowCirclePoint)���� �÷��̾ �ѷ��� ���� �߽�(vPlayerCirclePoint)���� �Ÿ�

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gPlayer = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * ȭ���� ������ �Ʒ��� 1�ʿ� �ϳ��� �������� ��� --> transform.Translate()
         * Translate �޼��� : ������Ʈ�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���
         *    Y ��ǥ�� -0.1f�� �����ϸ� ������Ʈ�� ���ݾ� ������ �Ʒ��� �����δ�
         *    �����Ӹ��� ������� ���Ͻ�Ų��.
         */

        // �����Ӹ��� ������� ���Ͻ�Ų��.
        transform.Translate(0, -0.1f, 0);

        /*
        * ȭ���� ����ȭ�� ������ ������ ȭ�� ������Ʈ�� �Ҹ��Ű�� ��� --> Destroy()
        * ȭ�� ������ ���� ȭ�� �Ҹ��Ű��
        *   ȭ���� ������ �θ� ȭ�� ������ ������ �ǰ�, ���� �������� ������ ��� ������
        *   ȭ���� ������ �ʴ� ������ ��� �������� ��ǻ�� ���� ����� �ؾ��ϹǷ� �޸� ����
        *   �޸𸮰� ������� �ʵ��� ȭ���� ȭ�� ������ ������ ������Ʈ�� �Ҹ���Ѿ� ��
        *   Destroy �޼��� : �Ű������� ������ ������Ʈ�� ����
        *   �Ű������� �ڽ�(ȭ�� ������Ʈ)�� ����Ű�� gameObject ������ �����ϹǷ� ȭ����
        *   ȭ�� ������ ������ �� �ڱ� �ڽ��� �Ҹ��Ŵ
        */

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��.
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        vArrowCirclePoint = transform.position;
        vPlayerCirclePoint = gPlayer.transform.position;
        vArrowPlayerDir = vArrowCirclePoint - vPlayerCirclePoint;

        fArrowPlayerDistance = vArrowPlayerDir.magnitude;

        if(fArrowPlayerDistance < fArrowRadius + fPlayerRadius)
        {
            Destroy(gameObject);
        }
    }
}
