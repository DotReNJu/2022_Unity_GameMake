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
    private static login instance = null;//�̱������� ���� ��ȿ�� �� ����!!
    // Start is called before the first frame update
    void Start()
    {
        this.login_b.onClick.AddListener(() =>
        {
            var url = string.Format("http://{0}:{1}/{2}", host, port, start_url);
            Debug.Log(url+"����");
            var req = new Protocols.Packets.logindata();
            req.cmd = 1000; //(int)Protocols.eType.POST_SCORE;
            req.id = ms.id;
            req.pw = ms.pw;
            //����ȭ 
            var json = JsonConvert.SerializeObject(req);
            Debug.Log(json);
            //{"id":"hong@nate.com","score":100,"cmd":1000}

        });//�͸��Լ��� ��������Ʈ�� ���� //js�� 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
