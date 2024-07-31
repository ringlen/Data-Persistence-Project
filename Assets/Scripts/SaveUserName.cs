using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class SaveUserName : MonoBehaviour
{
    public static SaveUserName saveName;
    public InputField inputField;
    public string userName;

    private void Awake()
    {
        if (saveName == null)
        {
            saveName = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (userName != inputField.text)

        {
            userName = inputField.text;
        }
    }
}
