using UnityEngine;

namespace Jason
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("¦å¶q"), Range(0, 10000)]
        protected float hp = 50;

        /// <summary>
        /// ¨ü¨ì¶Ë®`
        /// </summary>
        /// <param name="damage"></param>
        public void GetHurt(float damage)
        {
            hp -= damage;
            if (hp <= 0) Dead();
        }

        public void Dead()
        {
            hp = 0;
        }
    }
}