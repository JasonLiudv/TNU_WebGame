using UnityEngine;
using System.Collections;

namespace Jason
{
    public class HurtNumberEffect : MonoBehaviour
    {
        private CanvasGroup group;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();
        }

        //協同程序：控制系統等待、停止
        //1. 引用 System.Collections
        //2. 定義協同重續方法，傳回類型 IEnumerator
        //3. 使用 yield return new WaitForSeconds(等待秒數)
        //4. 使用啟動協同程序 StartCoroutine(協同程序方法)
        private IEnumerator Test()
        {
            yield return new WaitForSeconds(0);
        }
    }
}