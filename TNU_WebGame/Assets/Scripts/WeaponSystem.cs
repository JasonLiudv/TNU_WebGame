using UnityEngine;

namespace Jason
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
        private float timer;

        //作用：在編輯器內輔助用 執行不顯示
        private void OnDrawGizmos()
        {
            //決定顏色>>繪製圖示
            Gizmos.color = new Color(1, 0, 1, 0.5f);
            for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
        }

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            if (timer>= dataWeapon.interval)
            {
                timer = 0;
            }
        }
    }
}