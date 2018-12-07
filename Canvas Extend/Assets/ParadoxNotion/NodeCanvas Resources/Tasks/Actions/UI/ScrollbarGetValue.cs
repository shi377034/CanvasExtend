using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Actions
{
    [Name("Get Value")]
    [Category("UI/Scrollbar")]
    public class ScrollbarGetValue : ActionTask<Scrollbar>
    {
        [BlackboardOnly]
        public BBParameter<float> value;
        protected override void OnExecute()
        {
            value.value = agent.value;
            EndAction();
        }
    }
}