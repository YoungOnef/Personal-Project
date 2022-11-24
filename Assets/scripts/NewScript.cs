using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using MoonSharp.Interpreter;

public class NewScript : MonoBehaviour
{

    public TextMeshProUGUI userOutText;
    //public TMP_InputField userInputField;
    public GameObject inputField;

    public string ScriptText;

    void Start()
    {
        //string text = inputField.GetComponent<TMP_InputField>().text;
        /*StartLua(@"
        function test( n )
            return n * 2
        end
        ");
        */
    }
    public void inputText()
    {
        string script = inputField.GetComponent<TMP_InputField>().text;
        Debug.Log("script: " + script);


        StartLua (script);
    }


    public void StartLua(string rawLuaCode)
    {
        //creating a new script Object
        Script myLuaScript = new Script();
        //grabbing the result and run the script
        DynValue result = myLuaScript.DoString(rawLuaCode);

        //displaying the result
        Debug.Log(result.Number);

        double number = result.Number;
        setText(number);
        //calling the function and passing a number
        //result = myLuaScript.Call(myLuaScript.Globals["test"],20);

        //displaying the result
        //Debug.Log(result.Number);

    }
    public void setText(double number)
    {
        userOutText.text = number.ToString();

    }
}