using UnityEngine;

namespace Jason
{
    public class TopDownController : MonoBehaviour
    {
        #region Data
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
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
            
        }
        #endregion

        #region Method
        #endregion
    }
}