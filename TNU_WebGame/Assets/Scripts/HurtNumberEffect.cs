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

        //��P�{�ǡG����t�ε��ݡB����
        //1. �ޥ� System.Collections
        //2. �w�q��P�����k�A�Ǧ^���� IEnumerator
        //3. �ϥ� yield return new WaitForSeconds(���ݬ��)
        //4. �ϥαҰʨ�P�{�� StartCoroutine(��P�{�Ǥ�k)
        private IEnumerator Test()
        {
            yield return new WaitForSeconds(0);
        }
    }
}