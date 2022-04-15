using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jason
{
    public class WeaponUIController : MonoBehaviour
    {
        public List<Image> weaponIcon = new List<Image>();

        public void SelectIcon(int number)
        {
            for (int i = 0; i < weaponIcon.Count; i++)
            {
                weaponIcon[i].enabled = false;
            }
            weaponIcon[number].enabled = true;
        }
    }
}