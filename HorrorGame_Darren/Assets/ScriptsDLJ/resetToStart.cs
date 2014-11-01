using UnityEngine;
using System.Collections;

public class resetToStart : MonoBehaviour {
	public SceneFadeInOut script;
	public int executeNum = 0;
	private bool collided = false; 

	void changeExecuteNum(int num){
		this.executeNum = num;
	}

	void OnTriggerEnter(Collider collision) { 
		if(collision.gameObject.name=="iBoundary"){
			//Application.LoadLevel(0);
			collided = true;
		} 
		else if(collision.gameObject.name=="iBoundary2"){
			//Application.LoadLevel(0);
			collided = true;
			this.executeNum = 1;
		} 
	}

	void Update(){
		if (collided == true){
			if (executeNum == 0){
				script.EndScene();
			}
			else if (executeNum == 1){
				script.EndBeginning ();
			}
		}
	}
}
