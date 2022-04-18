using System.Collections.Generic;
using UnityEngine;


namespace Jason
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        private float timer;
        private static WeaponSystem instance = new WeaponSystem();

        public static WeaponSystem Instance { get { return instance; } set { } }
        public List<DataWeapon> weaponList = new List<DataWeapon>();
        public WeaponUIController weaponUIController;
        public System.Action OnAttack;

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
            SwitchWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            if (timer >= dataWeapon.interval)
            {
                OnAttack();
                GetComponent<TopDownController>().Attack();
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion �|�줸�G�������׸�T����
                //Quaternion.identity�s�ר�(0,0,0)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);
                timer = 0;
            }
        }

        public void SwitchWeapon()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                dataWeapon = weaponList[0];
                weaponUIController.SelectIcon(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                dataWeapon = weaponList[1];
                weaponUIController.SelectIcon(1);
            }
        }

        public void SwitchWeapon(DataWeapon weapon)
        {
            dataWeapon = weapon;
        }
    }
}