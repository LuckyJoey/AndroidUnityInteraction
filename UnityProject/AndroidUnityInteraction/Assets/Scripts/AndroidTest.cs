using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AndroidTest : MonoBehaviour
{
    public AndroidCall androidCall;
    public Text text;
    // Start is called before the first frame update
    public void OnClick()
    {
        text.text = androidCall.Call(23, 55).ToString();
    }
}
