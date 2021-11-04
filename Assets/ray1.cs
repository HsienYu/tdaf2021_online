using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray1 : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
    	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	//將主相機的螢幕座標轉為滑鼠座標

    	RaycastHit hit; //設定射線擊中目標為hit

    	//如果按下左鍵 && 物理射線(射線，out 目標)均存在
        if (Input.GetMouseButton(0) && Physics.Raycast(ray,out hit))
        {
        	Debug.Log(hit.transform.name); // 秀出被擊中的目標名稱
        }

    }
}
