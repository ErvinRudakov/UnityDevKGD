using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;
namespace Game{
    public class UpdateManager : MonoBehaviour{
        [SerializeField]
        private ScriptableEvent _updateEvent;
        void Update(){
            _updateEvent.Dispatch();
        }
    }
}
