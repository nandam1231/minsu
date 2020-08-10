﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Manager : MonoBehaviour
{
    public ButtonEvent buttonEvent;
    public Transform tractor; //you get transform of tractor
    //because if you take it as gameobject, you need to do
    //tractor.transform and it is not good. just not good.
    Vector2 originPos;
    //origin position of tractor.
    float moveLength = 4f;
    //move how long??

    private void Start()
    {
        originPos = tractor.position;
    }


    void Update()
    {
        if (buttonEvent.buttonTriggerd)
        {
           
            if(moveLength <= 0)
            {
                //if tractor goes 2f, it commits suicide
                Destroy(this);
            }
            else
            {
                originPos.x -= Time.deltaTime;
                tractor.position = originPos;
                moveLength -= Time.deltaTime;
            }
        }
    }
}
