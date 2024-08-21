using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerController : MonoBehaviour
{
    private bool isReadyToMove = false;

    void Update()
    {
        if (isReadyToMove)
        {
            //Z������ ȸ���Ѵ� 
            this.transform.Rotate(0, 0, -0.1f);

            //Y������ �̵��մϴ�.
            this.transform.Translate(0, 0.001f, 0, Space.World);
        }


    }

    public void Move()
    {
        isReadyToMove = true;
    }
}
