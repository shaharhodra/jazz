using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInvetort : MonoBehaviour
{
   public int NamberOfCarrot { get; private set; }
	public int numberOfHarts { get; private set; }
	public UnityEvent<PlayerInvetort> onCarrotColision;
	public void CarrotCollected()
	{
		
		NamberOfCarrot++;
		onCarrotColision.Invoke(this);
	}
	public void hartCollected()
	{
		numberOfHarts++;
		onCarrotColision.Invoke(this);
	}
	public void playerhit()
	{
		numberOfHarts--;
	}
	
}
