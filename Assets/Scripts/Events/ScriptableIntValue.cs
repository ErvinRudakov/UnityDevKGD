using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{

    [CreateAssetMenu(fileName = "Event", menuName = "Event")]
    public class ScriptableIntValue : ScriptableObject
    {
        public int score;
    }
}
