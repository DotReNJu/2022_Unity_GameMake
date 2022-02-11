using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Networking;
using Newtonsoft.Json;
using System.Text;


public class login : MonoBehaviour
{
    public string host;
    public int port;
    public string start_url;
    public InputField id;
    public InputField pw;
    public Button login_b;
    public MangerScript ms;
    private static login instance = null;//싱글톤으로 계정 유효성 및 보장!!
    // Start is called before the first frame update
    void Start()
    {
        this.login_b.onClick.AddListener(() =>
        {
            var url = string.Format("http://{0}:{1}/{2}", host, port, start_url);
            Debug.Log(url+"연결");
            var req = new Protocols.Packets.logindata();
            req.cmd = 1000; //(int)Protocols.eType.POST_SCORE;
            req.id = ms.id;
            req.pw = ms.pw;
            //직렬화 
            var json = JsonConvert.SerializeObject(req);
            Debug.Log(json);
            //{"id":"hong@nate.com","score":100,"cmd":1000}

        });//익명함수인 델리게이트로 구성 //js의 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
