// Touchable_Editor component, to prevent treating the component as a Text object.

using UnityEditor;

[CustomEditor(typeof(Touchable))]
public class Touchable_Editor : Editor
{
	public override void OnInspectorGUI ()
	{
		// Do nothing
	}
}
