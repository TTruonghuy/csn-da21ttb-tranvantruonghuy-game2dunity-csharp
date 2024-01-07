using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public int diem = 0;
    public TextMeshProUGUI TexTT;
    float thoigiantang = 0;
    
    void Update()
    {   
       thoigiantang += Time.deltaTime;
        if( thoigiantang >= 4)
        {
            diem++;thoigiantang = 0;
        }
        TexTT.text = "" + diem;
    }
}
