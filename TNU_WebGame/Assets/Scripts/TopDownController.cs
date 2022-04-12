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
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region Event
        private void Awake()
        {
            //print("Awake~");
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
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
        #endregion
    }
}