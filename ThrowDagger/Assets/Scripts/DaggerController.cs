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
            //Z축으로 회전한다 
            this.transform.Rotate(0, 0, -0.1f);

            //Y축으로 이동합니다.
            this.transform.Translate(0, 0.001f, 0, Space.World);
        }


    }

    public void Move()
    {
        isReadyToMove = true;
    }
}
