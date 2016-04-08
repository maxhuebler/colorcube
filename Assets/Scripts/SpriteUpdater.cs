using UnityEngine;
using System.Collections;

public class SpriteUpdater : MonoBehaviour
{
	public Sprite whiteWhiteSprite;
	public Sprite whiteBlueSprite;
	public Sprite blueRedSprite;
	public Sprite blueGreenSprite;
	public Sprite blueBlueSprite;
	public Sprite whiteRedSprite;
	public Sprite redBlueSprite;
	public Sprite redGreenSprite;
	public Sprite redRedSprite;
	public Sprite whiteGreenSprite;
	public Sprite greenBlueSprite;
	public Sprite greenRedSprite;
	public Sprite greenGreenSprite;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponentInChildren<SpriteRenderer>();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
	 if (coll.gameObject.tag == "RedPlatform")
		{
			// white white to white red
			if (spriteRenderer.sprite == whiteWhiteSprite)
			{
				spriteRenderer.sprite = whiteRedSprite;
				return;
			}

			// white blue to blue red
			if (spriteRenderer.sprite == whiteBlueSprite)
			{
				spriteRenderer.sprite = blueRedSprite;
				return;
			}

			// white red to solid red
			if (spriteRenderer.sprite == whiteRedSprite)
			{
				spriteRenderer.sprite = redRedSprite;
				return;
			}

			// white green to green red
			if (spriteRenderer.sprite == whiteGreenSprite)
			{
				spriteRenderer.sprite = greenRedSprite;
				return;
			}

			// blue to blue red
			if (spriteRenderer.sprite == blueBlueSprite)
			{
				spriteRenderer.sprite = blueRedSprite;
				return;
			}

			// blue red to solid red
			if (spriteRenderer.sprite == blueRedSprite)
			{
				spriteRenderer.sprite = redRedSprite;
				return;
			}

			// blue green to green red
			if (spriteRenderer.sprite == blueGreenSprite)
			{
				spriteRenderer.sprite = greenRedSprite;
				return;
			}

			// red blue to blue red
			if (spriteRenderer.sprite == redBlueSprite)
			{
				spriteRenderer.sprite = blueRedSprite;
				return;
			}

			// red green to green_red
			if (spriteRenderer.sprite == redGreenSprite)
			{
				spriteRenderer.sprite = greenRedSprite;
				return;
			}

			// red red to red red
			if (spriteRenderer.sprite == redRedSprite)
			{
				spriteRenderer.sprite = redRedSprite;
				return;
			}

			// green green to green red
			if (spriteRenderer.sprite == greenGreenSprite)
			{
				spriteRenderer.sprite = greenRedSprite;
				return;
			}

			// green blue to blue red
			if (spriteRenderer.sprite == greenBlueSprite)
			{
				spriteRenderer.sprite = blueRedSprite;
				return;
			}

			// green red to red red
			if (spriteRenderer.sprite == greenRedSprite)
			{
				spriteRenderer.sprite = redRedSprite;
				return;
			}

		}

		if (coll.gameObject.tag == "BluePlatform")
		{
			// white white to white blue
			if (spriteRenderer.sprite == whiteWhiteSprite)
			{
				spriteRenderer.sprite = whiteBlueSprite;
				return;
			}

			// white blue to blue blue
			if (spriteRenderer.sprite == whiteBlueSprite)
			{
				spriteRenderer.sprite = blueBlueSprite;
				return;
			}

			// white red to red blue
			if (spriteRenderer.sprite == whiteRedSprite)
			{
				spriteRenderer.sprite = redBlueSprite;
				return;
			}

			// white green to green blue
			if (spriteRenderer.sprite == whiteGreenSprite)
			{
				spriteRenderer.sprite = greenBlueSprite;
				return;
			}

			// solid blue to solid blue
			if (spriteRenderer.sprite == blueBlueSprite)
			{
				spriteRenderer.sprite = blueBlueSprite;
				return;
			}

			// blue red to red blue
			if (spriteRenderer.sprite == blueRedSprite)
			{
				spriteRenderer.sprite = redBlueSprite;
				return;
			}

			// blue green to green blue
			if (spriteRenderer.sprite == blueGreenSprite)
			{
				spriteRenderer.sprite = greenBlueSprite;
				return;
			}

			// red blue to solid blue
			if (spriteRenderer.sprite == redBlueSprite)
			{
				spriteRenderer.sprite = blueBlueSprite;
				return;
			}

			// red green to green blue
			if (spriteRenderer.sprite == redGreenSprite)
			{
				spriteRenderer.sprite = greenBlueSprite;
				return;
			}

			// red red to red blue
			if (spriteRenderer.sprite == redRedSprite)
			{
				spriteRenderer.sprite = redBlueSprite;
				return;
			}

			// green green to green blue
			if (spriteRenderer.sprite == greenGreenSprite)
			{
				spriteRenderer.sprite = greenBlueSprite;
				return;
			}

			// green blue to solid blue
			if (spriteRenderer.sprite == greenBlueSprite)
			{
				spriteRenderer.sprite = blueBlueSprite;
				return;
			}

			// green red to red blue
			if (spriteRenderer.sprite == greenRedSprite)
			{
				spriteRenderer.sprite = redBlueSprite;
				return;
			}
		}

		if (coll.gameObject.tag == "GreenPlatform")
		{
			// white white to white green
			if (spriteRenderer.sprite == whiteWhiteSprite)
			{
				spriteRenderer.sprite = whiteGreenSprite;
				return;
			}

			// white blue to blue green
			if (spriteRenderer.sprite == whiteBlueSprite)
			{
				spriteRenderer.sprite = blueGreenSprite;
				return;
			}

			// white red to red green
			if (spriteRenderer.sprite == whiteRedSprite)
			{
				spriteRenderer.sprite = redGreenSprite;
				return;
			}

			// white green to solid green
			if (spriteRenderer.sprite == whiteGreenSprite)
			{
				spriteRenderer.sprite = greenGreenSprite;
				return;
			}

			// solid blue to blue green
			if (spriteRenderer.sprite == blueBlueSprite)
			{
				spriteRenderer.sprite = blueGreenSprite;
				return;
			}

			// blue red to red green
			if (spriteRenderer.sprite == blueRedSprite)
			{
				spriteRenderer.sprite = redGreenSprite;
				return;
			}

			// blue green to solid green
			if (spriteRenderer.sprite == blueGreenSprite)
			{
				spriteRenderer.sprite = greenGreenSprite;
				return;
			}

			// red blue to blue green
			if (spriteRenderer.sprite == redBlueSprite)
			{
				spriteRenderer.sprite = blueGreenSprite;
				return;
			}

			// red green to solid green
			if (spriteRenderer.sprite == redGreenSprite)
			{
				spriteRenderer.sprite = greenGreenSprite;
				return;
			}

			// red red to red green
			if (spriteRenderer.sprite == redRedSprite)
			{
				spriteRenderer.sprite = redGreenSprite;
				return;
			}

			// solid green to solid green
			if (spriteRenderer.sprite == greenGreenSprite)
			{
				spriteRenderer.sprite = greenGreenSprite;
				return;
			}

			// green blue to blue green
			if (spriteRenderer.sprite == greenBlueSprite)
			{
				spriteRenderer.sprite = blueGreenSprite;
				return;
			}

			// green red to red green
			if (spriteRenderer.sprite == greenRedSprite)
			{
				spriteRenderer.sprite = redGreenSprite;
				return;
			}

		}
	}
}