using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateManagement.SessionState
{
    public class CounterState
    {
        private int _currentCount = 0;

        public EventHandler StateChange;
        
        public int GetCurretCount()
        {
            return _currentCount;
        }

        public void SetCurrentCount(int paramCount)
        {
            _currentCount = paramCount;
            StateHashanged();
        }

        public void ResetCurrentCount()
        {
            _currentCount = 0;
            StateHashanged();
        }

        private void StateHashanged()
        {
            StateChange?.Invoke(this, EventArgs.Empty);
        }
    }
}
