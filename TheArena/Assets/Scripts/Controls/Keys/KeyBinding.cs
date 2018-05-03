using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controls.Keys
{
    public interface KeyBinding
    {
        void FireAction(String key);
    }
}
