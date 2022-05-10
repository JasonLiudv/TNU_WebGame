using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Jason
{
    public class HurtNumberEffect : MonoBehaviour
    {
        [SerializeField, Header("�H�J�ƭ�"), Range(0, 0.5f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("�Y��ƭ�"), Range(0, 0.5f)]
        private float valueScale = 0.001f;
        [SerializeField, Header("�첾�ƭ�"), Range(0, 0.5f)]
        private float valueOffset = 0.1f;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textHurtNumber;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();
            rect = GetComponent<RectTransform>();
            textHurtNumber = transform.Find("DamageValue").GetComponent<Text>();

            #region ��P�{��
            StartCoroutine(Fade());
            StartCoroutine(Scale());
            StartCoroutine(Offset());

            StartCoroutine(Fade(-1, 0.8f));
            StartCoroutine(Scale(-1, 0.8f));
            StartCoroutine(Offset(-1, 0.8f)); 
            #endregion
        }

        public void UpdateHurtNumber(float damage)
        {
            textHurtNumber.text = damage.ToString();
        }

        //��P�{�ǡG����t�ε��ݡB����
        //1. �ޥ� System.Collections
        //2. �w�q��P�����k�A�Ǧ^���� IEnumerator
        //3. �ϥ� yield return new WaitForSeconds(���ݬ���)
        //4. �ϥαҰʨ�P�{�� StartCoroutine(��P�{�Ǥ�k)
        private IEnumerator Fade(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 10; i++)
            {
                group.alpha += valueFade * add;
                yield return new WaitForSeconds(0.02f);
            }
        }

        private IEnumerator Scale(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 5; i++)
            {
                rect.localScale += new Vector3(valueScale, valueScale, 0) * add;
                yield return new WaitForSeconds(0.02f);
            }
        }

        private IEnumerator Offset(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for (int i = 0; i < 10; i++)
            {
                rect.anchoredPosition += Vector2.up * valueOffset * add;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }
}