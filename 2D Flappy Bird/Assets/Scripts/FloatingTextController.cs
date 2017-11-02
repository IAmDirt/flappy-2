using UnityEngine;
using System.Collections;

public class FloatingTextController : MonoBehaviour {
	private static FloatingText popupText;
	private static GameObject canvas;
	public GameObject ting;

	public static void Initialize()
	{
		canvas = GameObject.Find("Canvas");
		if (!popupText)
			popupText = Resources.Load<FloatingText>("Prefabs/PopupTextParent");
	}

	public static void CreateFloatingText(string text, Transform location)
	{
		FloatingText instance = Instantiate(popupText);
		Vector2 screenPosition = GameObject.Find("PacMan").transform.position;

		instance.transform.SetParent(canvas.transform, false);
		instance.transform.position = screenPosition;
		instance.SetText(text);
	}
}