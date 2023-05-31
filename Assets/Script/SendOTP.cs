using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SendOTP : MonoBehaviour
{
    [SerializeField]
    TMP_InputField mobileNumber;
    [SerializeField]
    GameObject VerifyOTPScreen;
    [SerializeField]
    Toggle TandC;
    // Start is called before the first frame update
    public void SendOTPtoMobile()
    {
        if (mobileNumber.text.Length >= 10 && TandC.isOn)
            NextScreen();

    }
    public void SignupWithGoogle()
    {
        if(TandC.isOn)
            NextScreen();
    }

    void NextScreen()
    {
        VerifyOTPScreen.SetActive(true);
        gameObject.SetActive(false);
    }
}
