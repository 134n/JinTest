using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test :MonoBehaviour
{
    private delegate void CallBuck(string mes);

    [SerializeField] private string moji;
    
    // Start is called before the first frame update
    public void Start()
    {

        CallBuck callBuck = CallBuckMes;

        callBuck(moji);
        
    }

    void CallBuckMes(string mes)
    {
        Debug.Log(mes);
    }
}
