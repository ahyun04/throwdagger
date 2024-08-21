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

    //�̺�Ʈ �Լ� 
    private void Update()
    {
        //���� ���콺 ��ư�� �������� ��� 
        //0: left button
        bool isDown = Input.GetMouseButtonDown(0);

        bool isUp = Input.GetMouseButtonUp(0);

        if (isDown)
        {
            Debug.Log("ȭ���� �������ϴ�.");

            this.mouseDownPosition = Input.mousePosition;

        }
        else if (isUp)
        {
            Debug.Log("���콺�� �������ϴ�.");
            Vector3 mouseUpPosition = Input.mousePosition;

            Debug.Log($"{this.mouseDownPosition}, {mouseUpPosition}");

            float yDir = mouseUpPosition.y - this.mouseDownPosition.y;

            Debug.Log($"{yDir}");

            if (yDir > 0)
            {
                //��� 
                Debug.Log("�������� �������� �׼��� ��!");

                DaggerController controller = throwingStarsGo.GetComponent<DaggerController>();

                controller.Move();

            }
            else if (yDir < 0)
            {
                //���� 
                Debug.Log("�Ʒ���");
            }

        }



    }
}
