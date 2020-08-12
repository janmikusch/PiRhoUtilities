using System.Collections.Generic;
using System.Linq;

namespace PiRhoSoft.Utilities
{
    public class SceneSelectorAttribute : PropertyTraitAttribute
    {
        public SceneSelectorAttribute() : base(ControlPhase, 0)
        {
        }
    }
}