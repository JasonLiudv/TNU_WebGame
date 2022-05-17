using UnityEngine;
using UnityEngine.UI;

namespace Jason
{
    public class LevelManager : MonoBehaviour
    {
        private int lv = 1;
        private int exp;
        private int expMax;

        [SerializeField, Header("經驗值")]
        private Image imgExp;
        [SerializeField, Header("等級")]
        private Text textLv;
        [SerializeField, Header("經驗值需求表")]
        private int[] expsNeed;
        [SerializeField, Header("武器資料")] 
        private DataWeapon dataWeapon;

        [ContextMenu("Setting Exps Need")]
        private void SettingExpNeed()
        {
            expsNeed = new int[99];

            for (int i = 0; i < expsNeed.Length; i++)
            {
                expsNeed[i] = (i + 1) * 100;
            }
        }

        public void GetExp(int getExp)
        {
            exp += getExp;
            expMax = expsNeed[lv - 1];

            while (exp >= expMax)
            {
                lv++;
                exp -= expMax;
                expMax = expsNeed[lv - 1];

                LevelUp();
            }

            imgExp.fillAmount = (float)exp / (float)expMax;
            textLv.text = "LV " + lv;
        }

        private void LevelUp()
        {
            dataWeapon.attack += 10;
            dataWeapon.interval -= 0.02f;
        }
    }
}