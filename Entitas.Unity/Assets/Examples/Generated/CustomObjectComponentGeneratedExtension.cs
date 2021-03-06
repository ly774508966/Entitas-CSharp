//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public CustomObjectComponent customObject { get { return (CustomObjectComponent)GetComponent(VisualDebuggingComponentIds.CustomObject); } }
        public bool hasCustomObject { get { return HasComponent(VisualDebuggingComponentIds.CustomObject); } }

        public Entity AddCustomObject(CustomObject newCustomObject) {
            var component = CreateComponent<CustomObjectComponent>(VisualDebuggingComponentIds.CustomObject);
            component.customObject = newCustomObject;
            return AddComponent(VisualDebuggingComponentIds.CustomObject, component);
        }

        public Entity ReplaceCustomObject(CustomObject newCustomObject) {
            var component = CreateComponent<CustomObjectComponent>(VisualDebuggingComponentIds.CustomObject);
            component.customObject = newCustomObject;
            ReplaceComponent(VisualDebuggingComponentIds.CustomObject, component);
            return this;
        }

        public Entity RemoveCustomObject() {
            return RemoveComponent(VisualDebuggingComponentIds.CustomObject);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherCustomObject;

        public static IMatcher CustomObject {
            get {
                if(_matcherCustomObject == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.CustomObject);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherCustomObject = matcher;
                }

                return _matcherCustomObject;
            }
        }
    }
