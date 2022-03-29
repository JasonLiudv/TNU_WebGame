using UnityEngine;

namespace Jason
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        private float timer;

        //�@�ΡG�b�s�边�����U�� ���椣���
        private void OnDrawGizmos()
        {
            //�M�w�C��>>ø�s�ϥ�
            Gizmos.color = new Color(1, 0, 1, 0.5f);
            for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
        }

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            if (timer>= dataWeapon.interval)
            {
                timer = 0;
            }
        }
    }
}