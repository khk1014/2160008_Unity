// 화살이 위에서 아래로 1초에 하나씩 떨어지는 기능 --> transform.Translate()
// 화살이 게임화면 밖으로 나오면 화살 오브젝트를 소멸시키는 기능 --> Destroy()

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // 멤버변수 선언
    GameObject gPlayer = null; // Player Object를 저장할 GameObject 변수, GameObject 변수의 초깃값은 null

    Vector2 vArrowCirclePoint = Vector2.zero; // 화살을 둘러싼 원의 중심 좌표
    Vector2 vPlayerCirclePoint = Vector2.zero; // 플레이어를 둘러싼 원의 중심 좌표
    Vector2 vArrowPlayerDir = Vector2.zero; // 화살에서 플레이어까지의 백터값

    float fArrowRadius = 0.5f;          // 화살 원의 반지름 0.5
    float fPlayerRadius = 1.0f;         // 플레이어 원의 반지름 1.0
    float fArrowPlayerDistance = 0.0f;  // 화살의 중심(vArrowCirclePoint)부터 플레이어를 둘러싼 원의 중심(vPlayerCirclePoint)까지 거리

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gPlayer = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 화살이 위에서 아래로 1초에 하나씩 떨어지는 기능 --> transform.Translate()
         * Translate 메서드 : 오브젝트를 현재 좌표에서 인수 값만큼 이동시키는 메서드
         *    Y 좌표에 -0.1f를 지정하면 오브젝트를 조금씩 위에서 아래로 움직인다
         *    프레임마다 등속으로 낙하시킨다.
         */

        // 프레임마다 등속으로 낙하시킨다.
        transform.Translate(0, -0.1f, 0);

        /*
        * 화살이 게임화면 밖으로 나오면 화살 오브젝트를 소멸시키는 기능 --> Destroy()
        * 화면 밖으로 나온 화살 소멸시키기
        *   화살을 내버려 두면 화면 밖으로 나가게 되고, 눈에 보이지는 않지만 계속 떨어짐
        *   화살이 보이지 않는 곳에서 계속 떨어지면 컴퓨터 역시 계산을 해야하므로 메모리 낭비
        *   메모리가 낭비되지 않도록 화살이 화면 밖으로 나가면 오브젝트를 소멸시켜야 함
        *   Destroy 메서드 : 매개변수로 전달한 오브젝트를 삭제
        *   매개변수로 자신(화살 오브젝트)을 가르키는 gameObject 변수를 전달하므로 화살이
        *   화면 밖으로 나가을 때 자기 자신을 소멸시킴
        */

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다.
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
