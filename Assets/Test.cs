using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
        // Use this for initialization
        void Start ()
        {
                // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
                int[] array = new int[5];


               // 配列の各要素に値を代入する
                array [0] = 10;
                array [1] = 20;
                array [2] = 30;
                array [3] = 40;
                array [4] = 50;

                // for文を使い、配列の各要素の値を順番に表示する
                for (int i = 0; i < 5; i++)
                {
                    Debug.Log (array [i]);
                }

                // for文を使い、配列の各要素の値を逆順に表示する
                for (int i = array.Length -1; 0<= i; i-- )
                {
                    Debug.Log (array [i]);
                }

　　    }
    // Update is called once per frame
    void Update (){
    
    }
}
