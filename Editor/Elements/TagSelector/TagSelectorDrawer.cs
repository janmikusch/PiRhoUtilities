using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace PiRhoSoft.Utilities.Editor
{
    [CustomPropertyDrawer(typeof(TagSelectorAttribute))]
    class TagDrawer : PropertyDrawer
    {
        private const string _invalidTypeError = "(PUCBDIT) invalid type for TagSelectorAttribute on field '{0}': TagSelector can only be applied to string fields";

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            if (property.propertyType == SerializedPropertyType.String)
            {
                var tagSelector = new TagSelectorField();
                tagSelector.SetValues(UnityEditorInternal.InternalEditorUtility.tags.ToList());

                return tagSelector.ConfigureProperty(property);
            }
            else
            {
                Debug.LogErrorFormat(_invalidTypeError, property.propertyPath);
                return new FieldContainer(property.displayName);
            }
        }
    }
}