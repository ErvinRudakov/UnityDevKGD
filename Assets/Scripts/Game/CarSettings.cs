using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "Cars", menuName = "Cars")]
    public class CarSettings : ScriptableObject
    {
        public int dodgeScore;
    }

}
