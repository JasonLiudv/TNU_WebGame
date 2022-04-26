using UnityEngine;

namespace Jason
{
    public class EnemySystem : MonoBehaviour
    {
        /// <summary>
        /// 敵人系統
        /// </summary>
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "CowBoy";

        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find(namePlayer).transform;

            //float result = Mathf.Lerp(0, 100, 0.5f);
        }

        private void Update()
        {
            MoveToPlayer();
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}