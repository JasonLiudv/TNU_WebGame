using UnityEngine;
using UnityEngine.UI;

namespace Jason
{
    [CreateAssetMenu(menuName = "Jason/Data Weapon", fileName = "Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500f;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(0, 10)]
        public float countStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public int countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
        [Header("�Z���w�m��")]
        public GameObject goWeapon;
        //[Header("�Z���Ϯ�")]
        public Image iconWeapon { get { return goWeapon.GetComponent<Image>(); } set { } }
        [Header("�����V")]
        public Vector3 v3Direction;
    }
}