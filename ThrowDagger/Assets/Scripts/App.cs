using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public GameObject throwingStarsGo;

    private Vector3 mouseDownPosition;

    void Start()
    {

    }

    //이벤트 함수 
    private void Update()
    {
        //왼쪽 마우스 버튼을 눌렀을때 출력 
        //0: left button
        bool isDown = Input.GetMouseButtonDown(0);

        bool isUp = Input.GetMouseButtonUp(0);

        if (isDown)
        {
            Debug.Log("화면을 눌렀습니다.");

            this.mouseDownPosition = Input.mousePosition;

        }
        else if (isUp)
        {
            Debug.Log("마우스를 떼었습니다.");
            Vector3 mouseUpPosition = Input.mousePosition;

            Debug.Log($"{this.mouseDownPosition}, {mouseUpPosition}");

            float yDir = mouseUpPosition.y - this.mouseDownPosition.y;

            Debug.Log($"{yDir}");

            if (yDir > 0)
            {
                //양수 
                Debug.Log("위쪽으로 스와이프 액션을 함!");

                DaggerController controller = throwingStarsGo.GetComponent<DaggerController>();

                controller.Move();

            }
            else if (yDir < 0)
            {
                //음수 
                Debug.Log("아래쪽");
            }

        }



    }
}
