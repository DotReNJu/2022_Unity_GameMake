using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protocols : MonoBehaviour
{
    public class Packets
    {
        public class Common
        {
            public int cmd;
        }
        public class logindata : Common
        {
            public string id;
            public string pw;
        }
    }
}
