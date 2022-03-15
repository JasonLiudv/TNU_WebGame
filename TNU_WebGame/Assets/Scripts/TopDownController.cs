using UnityEngine;

namespace Jason
{
    public class TopDownController : MonoBehaviour
    {
        #region Data
        private float speed = 10.5f;
        private string parameterRun = "開關跑步";
        private string parameterDead = "開關死亡";
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