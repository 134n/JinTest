using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private delegate void CallBuck(string mes);
    private delegate void Delegate(int count);

    [SerializeField] private string moji;
    [SerializeField] private int c;

    [SerializeField] private string a;
    [SerializeField] private string b;

    // Start is called before the first frame update
    public void Start()
    {
        //デリゲート
        CallBuck callBuck = CallBuckMes;
        callBuck(moji);

        //ラムダ式＋デリゲート 
        Delegate dele = (count) => Debug.Log(count);
        dele(c);

        //文字列補完
        Mhk();

    }

    void CallBuckMes(string mes)
    {
        Debug.Log(mes);
    }

    void Mhk()
    {
        string A = string.Format($"aaa{a}bbb{b}ccc");
        string B = $"aaa{a}bbb{b}ccc";

        Debug.Log(A);
        Debug.Log(B);
    }

    //リテラル　int = 1←みたまんまの値

    //整数型
    //byte
    //sbyte
    //short
    //ushort
    //int
    //uint
    //long
    //ulong

    //エスケープシーケンスまじわからん /aとか

    //浮動小数点　float とか　double(２倍精度)　とか　デシマル10(進数小数)とか

    //文字列　""

    //逐語的文字列リテラルはまじわからん　＠付けると　/　とかが文字として認識されるらしい

    //理論値　bool true false

    //object型　null←初期化前の値

    //.Netの型　system.なんちゃら

    //規定値(default) 変数を明示的に初期化しなかった場合に与えられる値　int n = default(int);←0 



    //ラムダ式  (int,int) => {return a+b;};  (a,b) => a+b; 


}
