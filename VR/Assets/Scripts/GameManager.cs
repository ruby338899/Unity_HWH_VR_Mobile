using UnityEngine;
using System.Collections; //引用 系統.集合 API、延遲 - 只要System就是微軟   API
public class GameManager : MonoBehaviour
{
    //定義欄位(Field 宣告變數)
    //修飾詞、類型、名稱;
    //public、公開:顯示在屬性面板上
    //GameObject、遊戲物件:儲存階層面板內的物件
   
    /// <summary>
    /// 燈光群組
    /// </summary>
    [Header("燈光群組")]
     public GameObject groupLight;
    [Header("椅子")]
    public Transform chair;

    //定義方法(Method):有特定內容的功能
    //修飾詞  傳回類型 方法名稱 ()  { 敘述 }
    //void 為無傳回 :使用方法不會得到任何資料
    //IEnumerator 延遲傳回
    //協同程序:多線程 程式處理方式   (像多條線分開進行各自的工作,不會因為某條線需停止而導致全部停止)
    ///<summary>燈光閃爍效果
    public IEnumerator LihghtEffect()
    {
        //燈光群組.啟動設定(隱藏)
        groupLight.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        groupLight.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        groupLight.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        groupLight.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        groupLight.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        groupLight.SetActive(true);
        yield return new WaitForSeconds(0.4f);

    }

    //事件:開始 - 播放時執行一次
    private void Start()
    {

        //LihghtEffect();                          //呼叫自定義的方法:這是為一般的呼叫方式
        StartCoroutine(LihghtEffect());            //呼叫類型為協程方式
    }
}
