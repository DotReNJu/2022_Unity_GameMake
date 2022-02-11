using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainTEST : MonoBehaviour
{
    public Text ScriptTxt;
    public int testINT = 0;

    public int hideCanvas = 0;
    public GameObject mainCanvas;
    
    private void Start() {
        
    }
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            //마우스 좌클릭 처리
            mainCanvas.SetActive(true);
            hideCanvas=0;
        }
    }
    public void onclickTEST(){
        testINT++;
        ScriptTxt.text=testINT.ToString();
    }
    public void onclickHideCanvas(){
        if(hideCanvas==0){
            mainCanvas.SetActive(false);
            hideCanvas=1;
        }else{
            mainCanvas.SetActive(true);
            hideCanvas=0;
        }
    }
}
