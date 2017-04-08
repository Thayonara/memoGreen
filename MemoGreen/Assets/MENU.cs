using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class MENU : MonoBehaviour {

	public Button BotaoJogar,BotaoSobre,BotaoSair;
	[Space(20)]
	public Button BotaoVoltar;
	[Space(20)]
	public string nomeCenaJogo = "mg";
	private string nomeDaCena;
	public Text text1;
	public Text text2;
	public Text text3;
	public Image imagem1;
	public Image imagem2;
	public Image imagem3;


	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}

	void Start () {
		Sobre (false);
		//
		nomeDaCena = SceneManager.GetActiveScene ().name;
		Cursor.visible = true;
		Time.timeScale = 1;
	
		// =========SETAR BOTOES==========//
		BotaoJogar.onClick = new Button.ButtonClickedEvent();
		BotaoSobre.onClick = new Button.ButtonClickedEvent();
		BotaoSair.onClick = new Button.ButtonClickedEvent();
		BotaoVoltar.onClick = new Button.ButtonClickedEvent();
		BotaoJogar.onClick.AddListener(() => Jogar());
		BotaoSobre.onClick.AddListener(() => Sobre(true));
		BotaoSair.onClick.AddListener(() => Sair());
		BotaoVoltar.onClick.AddListener(() => Sobre(false));
		imagem1.gameObject.SetActive (true);
		imagem2.gameObject.SetActive (true);
		text3.gameObject.SetActive (true);

	}

	//=========VOIDS DE CHECAGEM==========//


	private void Sobre(bool ativarOP){
		BotaoJogar.gameObject.SetActive (!ativarOP);
		BotaoSobre.gameObject.SetActive (!ativarOP);
		BotaoSair.gameObject.SetActive (!ativarOP);
		imagem2.gameObject.SetActive (!ativarOP);
		text3.gameObject.SetActive (!ativarOP);
		//
		BotaoVoltar.gameObject.SetActive (ativarOP);
		text1.gameObject.SetActive (ativarOP);
		text2.gameObject.SetActive (ativarOP);
		imagem3.gameObject.SetActive (ativarOP);
	}



	//===========VOIDS NORMAIS=========//
	void Update(){
		if (SceneManager.GetActiveScene ().name != nomeDaCena) {
			Destroy (gameObject);
		}
	}
	private void Jogar(){
		SceneManager.LoadScene (nomeCenaJogo);
	}
	private void Sair(){
		Application.Quit ();
	}
}
