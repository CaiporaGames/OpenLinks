using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class Manager : MonoBehaviour
{
    [DllImport("__Internal")]
    static extern void OpenTab(string url);
    public void OpenURL(TMP_InputField inputField)
    {
        if (inputField.text == "")
        {
            return;
        }
        OpenTab(inputField.text);
    }
}
