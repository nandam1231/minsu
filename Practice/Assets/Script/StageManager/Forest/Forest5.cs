﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Forest5 : MonoBehaviour
{
    private bool IsRotate;

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;   //디바이스가 세워진 상태에서 홈 버튼이 오른쪽에 있는 가로 모드입니다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isRotate()
    {
        if (Input.deviceOrientation == DeviceOrientation.LandscapeRight) //device의 방향이 반대로 되었다면
        {
            IsRotate = true;
        }
        else
        {
            IsRotate = false;
        }
    }


}



//https://docs.unity3d.com/kr/2018.4/Manual/AndroidMobileAdvanced.html 참조