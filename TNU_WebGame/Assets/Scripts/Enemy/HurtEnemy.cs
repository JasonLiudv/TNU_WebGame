using UnityEngine;
namespace Jason
{
    public class HurtEnemy : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }
}