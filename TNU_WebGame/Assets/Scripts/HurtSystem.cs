using UnityEngine;

namespace Jason
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("��q"), Range(0, 10000)]
        protected float hp = 50;

        /// <summary>
        /// ����ˮ`
        /// </summary>
        /// <param name="damage"></param>
        public virtual void GetHurt(float damage)
        {
            if (hp <= 0) return;

            hp -= damage;

            if (hp <= 0) Dead();
        }

        protected virtual void Dead()
        {
            hp = 0;
        }
    }
}