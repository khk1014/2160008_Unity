/*
  화살 오브젝트를 1초에 한 개씩 생성하는 알고리즘
 - Update 메서드는 프레임마다 실행되고 앞 프레임과 현재 프레임 사이의 시간 차이는 Time.deltaTime에 대입
 - 프레임과 프레임 사이의 시간 차이를 대나무 통(delta변수)에 모으고(합계) 1초 이상이 되면 대나무 통을 비움
 - 대나무 통을 비우는 시점인 1초에 한 번씩 화살이 생성됨
 - Instantiate 메서드
   -- 게임을 실행하는 도중에 게임오브젝트를 생성할 수 있음
   -- 화살 프리팹을 이용하여, 화살 인스턴스를 생성하는 메서드
 - Random.Range 메서드
 */

using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject gArrowPrefab = null;  // 화살 프리팹을 넣은 빈오브젝트 상자 선언

    GameObject gArrowInstance = null;       // 화살 인스턴스 저장 변수

    float fArrowCreateSpen = 0.5f;          // 화살이 생성 변수 : 화살을 1초마다 생성 변수
    float fDeltaTime = 0.0f;                // 앞 프레임과 현재 프레임 사이의 시간 차이를 저장하는 변수

    int nArrowPositionRange = 0;            // 화살의 X 좌표 Range 저장 변수

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
