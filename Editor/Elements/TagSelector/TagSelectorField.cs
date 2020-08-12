using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace PiRhoSoft.Utilities.Editor
{
	public class TagSelectorField : PopupField<string>
	{
		public TagSelectorField() { }
		public TagSelectorField(string label) : base(label) { }
		public TagSelectorField(string label, List<string> values, List<string> options = null) : base(label, values, options) { }
		public TagSelectorField(List<string> values, List<string> options = null) : base(values, options) { }

		public new class UxmlFactory : UxmlFactory<TagSelectorField, UxmlTraits<UxmlStringAttributeDescription>> { }

		protected override List<string> ParseValues(string[] from)
		{
			return from.ToList();
		}
	}
}
