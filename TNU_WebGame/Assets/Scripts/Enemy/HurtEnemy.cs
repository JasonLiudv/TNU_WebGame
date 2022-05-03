using UnityEngine;
namespace Jason
{
    public class HurtEnemy : HurtSystem
    {
        [SerializeField, Header("¼Ä¤H¸ê®Æ")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }
}