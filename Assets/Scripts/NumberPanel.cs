using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberPanel : MonoBehaviour
{
    [SerializeField] TMP_Text numberText; // 表示する数字
    public int number = 0; // 内部の数字

    // クリックされたら数字を増やす
    public void OnClick() 
    {
        number++; // 数字を1つ増やす

        // 10以上になったら0に戻す
        if(number >= 10) 
        {
            number = 0;       
        }

        // TextMeshProのテキストを更新
        numberText.text = number.ToString();    
    }
}