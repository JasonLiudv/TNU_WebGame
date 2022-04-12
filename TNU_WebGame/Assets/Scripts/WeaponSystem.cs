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

        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);
            Physics2D.IgnoreLayerCollision(6, 6);
            Physics2D.IgnoreLayerCollision(6, 7);
        }

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            if (timer >= dataWeapon.interval)
            {
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion �|�줸�G�������׸�T����
                //Quaternion.identity�s�ר�(0,0,0)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);
                timer = 0;
            }
        }
    }
}