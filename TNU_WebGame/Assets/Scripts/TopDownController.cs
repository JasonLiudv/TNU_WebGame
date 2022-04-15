using System.Collections.Generic;
using UnityEngine;

namespace Jason
{
    /// <summary>
    /// ���ⱱ��GTop Down ����
    /// </summary>
    public class TopDownController : MonoBehaviour
    {
        #region Data
        [SerializeField, Header("���ʳt��"), Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "Switch_Walk";
        private string parameterDead = "Switch_Die";
        private string parameterAttack = "Switch_Attack";
        private Animator ani;
        private Rigidbody2D rig;
        private WeaponSystem weaponSystem;
        private float h;
        private float v;
        #endregion

        #region Event
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            weaponSystem = GetComponent<WeaponSystem>();
        }

        private void Update()
        {
            GetInput();
            Move();
        }
        #endregion

        #region Method
        /// <summary>
        /// ���o���a��J���
        /// �W�U���k
        /// </summary>
        private void GetInput()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }

        private void Move()
        {
            rig.velocity = new Vector2(h, v) * speed;
            ani.SetBool(parameterRun, h != 0 || v != 0);

            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }

        public void Attack()
        {
            ani.Play("Attack");
        }
        #endregion
    }
}