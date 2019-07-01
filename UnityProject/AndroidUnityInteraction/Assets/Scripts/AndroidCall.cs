using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
public class AndroidCall : MonoBehaviour
{
    AndroidJavaObject jo=null;
    // Start is called before the first frame update
    void Start()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        jo = jc.GetStatic<AndroidJavaObject>("currentActivity");//获取当前Activity对象，即Android中的MainActivity 
    }
    public int Call(int a,int b)
    {
        int res = jo.Call<int>("add", 56, 100);
        return res;
    }
}
