using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class WebPlayerTemplatesPostProcessBuild
{
	[PostProcessBuild]
	public static void OnPostprocessBuild (BuildTarget target, string pathToBuiltProject)
	{
		if (target == BuildTarget.WebPlayer) {
			Application.CaptureScreenshot (pathToBuiltProject + "/thumbnail.png");
		}
	}
}
