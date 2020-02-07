using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonContainer : MonoBehaviour
{
	private int score = 0;
	private float timer = 0.0f;
	private float threshold = 0.0f;
	public TextMeshProUGUI scoreText;
	public List<ButtonClickHandler> buttons;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer >= threshold)
		{
			timer = 0.0f;
			threshold = Random.Range(0, 3);
			StartCoroutine(ColorButton());
		}
	}

	public void IncreaseScore()
	{
		score += 1;
		scoreText.text = "" + score;
	}

	public void ResetScore()
	{
		score = 0;
		scoreText.text = "" + score;
	}

	private IEnumerator ColorButton()
	{
		int random = Random.Range(0, 8);
		buttons[random].SetColored(Random.ColorHSV());

		yield return new  WaitForSeconds(Random.Range(0.5f, 2));

		buttons[random].SetColored(Color.white);
	}
}
