using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

namespace PiRhoSoft.Utilities.Editor
{
    [CustomPropertyDrawer(typeof(SceneSelectorAttribute))]
    class SceneSelectorDrawer : PropertyDrawer
    {
        private const string _invalidTypeError =
            "(PUCBDIT) invalid type for TagSelectorAttribute on field '{0}': TagSelector can only be applied to string fields";

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            if (property.propertyType == SerializedPropertyType.String)
            {
                var comboBox = new ComboBoxField();

                void options()
                {
                    var scenes = new List<string>();

                    for (var i = 0; i < EditorSceneManager.sceneCountInBuildSettings; i++)
                    {
                        var scene = EditorSceneManager.GetSceneByBuildIndex(i);
                        scenes.Add(scene.name);
                    }

                    comboBox.Options = scenes;
                }

                var action = new Action(options);

                action.Invoke();
                comboBox.schedule.Execute(action).Every(100);

                return comboBox.ConfigureProperty(property);
            }
            else
            {
                Debug.LogErrorFormat(_invalidTypeError, property.propertyPath);
                return new FieldContainer(property.displayName);
            }
        }
    }
}