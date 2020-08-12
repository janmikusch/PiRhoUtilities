using System.Collections.Generic;
using System.Linq;

namespace PiRhoSoft.Utilities
{
    public class TagSelectorAttribute : PropertyTraitAttribute
    {
        public TagSelectorAttribute() : base(ControlPhase, 0)
        {
        }
    }
}