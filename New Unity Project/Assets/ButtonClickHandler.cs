using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
	public ButtonContainer buttonContainer;
	public Image image;

	public void SetColored(Color color)
	{
		image.color = color;
	}

	public void OnClick()
	{
		if (image.color != Color.white)
		{
			buttonContainer.IncreaseScore();
			SetColored(Color.white);
		}
	}
}
