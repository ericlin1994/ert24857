using UnityEngine;
using System.Collections;

public class test: MonoBehaviour {
	const int sentence_max = 17 , card_group_max = 8 , card_group_number_max = 9 , card_invalid_max = 24 , card_valid_max = 48 , card_correct_max = 2 , card_wrong_max = 1  ;
	public GameObject time,bt_start,start_view,card_answer,right_list_SV, AI_card_SV,bt_0_0,bt_0_1,bt_1_0,bt_1_1,bt_2_0,bt_2_1,help,chinese_first_sentence,chinese_second_sentence,chinese_third_sentence,help_hint_view,chinese_word,part_of_speech,english_word,card_time_cd,click_card,change_card ;
	public GameObject bt_ai_correct, bt_ai_wrong , bt_quit;
	public GameObject Game_over;
	GameObject[] cluster;
	//GameObject[][] card;
	GameObject[] card_view_SV;
	GameObject[][] main_view_SV;
	int level;
	public int last_shadow_num;
	public int card_light_count;

	int AI_last_num_i;
	int AI_last_num_j;

	int last_num_i;
	int last_num_j;
	int last_bt_num_i;
	int last_bt_num_j;
	int score;
	int AI_score;
	int hint_score;
	public int correct_sum,wrong_sum;
	public int send_cd_count;
	int[][] card_index;
	int correct_count;
	int wrong_count;
	int AI_correct_count;
	int AI_wrong_count;


	public string[][] eighty;
	//string[] sixty;
	public string[] twenty;
	string[][] sentence;
	string[] answer_str;

	string [] odd_even_odd;
	string [] even_odd_even;
	public string [][] no_key_word;
	string last_change_card;
	bool[] is_turn_on;
	bool[][] card_turn_on;
	bool [][]sentence_isover;
	bool isfind;
	bool AI_isfind;
	bool AI_card_isfind;
	bool let_go;
	bool player_cd;
	bool shield;
	bool first_sentence;
	bool second_sentence;
	bool third_sentence;
	//bool start;


	public bool r_1;
	public bool r_2;
	public bool r_3;
	public bool l_1;
	public bool l_2;
	public bool l_3;




	//UISprite start_view_US;
	//UISprite bg_choose_view_US;
	UISprite[] cluster_shadow_US;
	UISprite card_time_cd_US;
	UISprite computer_chance_US;


	
	UILabel bt_start_UL;
	UILabel bt_0_0_UL;
	UILabel bt_0_1_UL;
	UILabel bt_1_0_UL;
	UILabel bt_1_1_UL;
	UILabel bt_2_0_UL;
	UILabel bt_2_1_UL;
	UILabel [][]card_answer_UL;
	UILabel Score_UL;
	public UILabel AI_score_UL;
	UILabel time_UL;
	UILabel []answer_UL;
	UILabel helper_UL;
	UILabel card_UL;
	//UILabel chinese_sentence_UL;
	UILabel[] first_sentence_UL;
	UILabel[] second_sentence_UL;
	UILabel[] third_sentence_UL;
	UILabel  help_view_chinese_word_UL;
	UILabel hint_score_UL;
	UILabel  card_time_cd_UL;
	UILabel  AI_view_UL;
	UILabel start_view_UL;
	UILabel start_view_UL_one;
	UILabel card_view_chinese_word_UL;
	UILabel correct_UL;
	UILabel wrong_UL;
	UILabel AI_correct_UL;
	UILabel AI_wrong_UL;
	UILabel hint_UL;
	UILabel first_time_UL;
	UILabel second_time_UL;
	UILabel third_time_UL;
	UILabel Game_over_UL;

	public UIGrid []cluster_UG;
	public UIGrid right_list_SV_UG;
	public UIGrid AI_card_SV_UG;
	bool is_start;
	float time_f = 0f;
	float first_time_f = 0f;
	float second_time_f = 0f;
	float third_time_f = 0f;
	int time_m , time_h , time_s , first_time_m , first_time_s , second_time_m , second_time_s , third_time_m , third_time_s;
	data d_obj = new data();
	public Transform []cluster_pos;
	txtIO tx;
	// Use this for initialization
	void Start () {
		

		card_time_cd_UL.text = send_cd_count.ToString();

		bt_start_UL.text = "Start";
		Game_over_UL.text = "Game Over";
		bt_0_0_UL.text = "←";
		bt_0_1_UL.text = "→";
		bt_1_0_UL.text = "←";
		bt_1_1_UL.text = "→";
		bt_2_0_UL.text = "←";
		bt_2_1_UL.text = "→";
		helper_UL.text = "小幫手-50";
		//chinese_sentence_UL.text = "句意提示-20";
		start_view_UL_one.text = "請選擇卡牌" ;



		first_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
		second_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
		third_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
		//string[] sixty = d_obj.get_sentence_word(int level_num ,int sentence_num );
		StartCoroutine(delay_grid(0, 0.2f));
		set_card ();

	}
		
	void Awake(){

		last_change_card = "";
		tx = GameObject.Find ("script_obj").GetComponent<txtIO> ();
		level = 0;

		AI_last_num_i = -1;
		AI_last_num_j = -1;
		last_num_i = -1;
		last_num_j = -1;
		time_f = 5400;
		first_time_f = 180;
		second_time_f = 180;
		third_time_f = 180;
		score = 1000;
		AI_score = 1000;
		hint_score = 3000;
		send_cd_count = 3;
		correct_count = 0;
		wrong_count = 0;
		AI_correct_count = 0;
		AI_wrong_count = 0;


		r_1 = false;
		r_2 = false;
		r_3 = false;
		l_1 = false;
		l_2 = false;
		l_3 = false;

		sentence_isover = new bool[2][];
		sentence_isover[0] = new bool[3];
		sentence_isover[1] = new bool[3];
		for(int i=0;i<2;i++){
			for (int j = 0; j < 3; j++) {
				sentence_isover [i] [j] = false;
			}
		}

		card_index = new int[2][];
		card_index[0] = new int[3];
		card_index[1] = new int[3];



		answer_str = new string[3];
		answer_UL = new UILabel[sentence_max];
		first_sentence_UL = new UILabel[100];
		second_sentence_UL = new UILabel[100];
		third_sentence_UL = new UILabel[100];
		//last_shadow_num = -1;
		is_turn_on = new bool[card_group_max];
		card_turn_on = new bool[card_group_max][];


		sentence  = new string[3][];//宣告三句子陣列
		sentence[0] = new string[sentence_max];//第一句	
		sentence[1] = new string[sentence_max];//第二句
		sentence[2] = new string[sentence_max];//第三句

		//sixty = new string[(sentence_max-1)*3];//有效卡牌60格陣列
		even_odd_even = new string[((sentence_max-1)*3)/2];
		odd_even_odd = new string[((sentence_max-1)*3)/2];

		no_key_word = new string[3][] ;
		for (int i = 0; i < 3; i++) {
			no_key_word [i] = new string[sentence_max-1];
		}
		twenty = new string[card_invalid_max];//無效卡牌20格陣列


		eighty = new string[card_group_max][];//宣告eighty 80個陣列
		//card = new GameObject[card_group_max][];//宣告卡片物件40個(手牌)
	

		card_answer_UL = new UILabel[card_group_max][];//宣告card_answer label 80個陣列



		main_view_SV = new GameObject[3][];
		for (int i = 0; i < 3 ; i++) {
			main_view_SV[i] = new GameObject[sentence_max];
			answer_UL [i] = GameObject.Find ("bg (" + i.ToString () + ")/Label").GetComponent<UILabel>();

			card_index [0] [i] = d_obj.get_key_word (i) + 1;
			card_index [1] [i] = d_obj.get_key_word (i) - 1;
		}


		//start = false;
		player_cd = true;
		let_go = true;
		isfind = false;
		AI_isfind = false;
		is_start = false;
		shield = false;
		first_sentence = false;
		second_sentence = false;
		third_sentence = false;

		Game_over = GameObject.Find ("Game_over");
		change_card = GameObject.Find ("change_card");
		card_time_cd = GameObject.Find ("card_time_cd");
		time = GameObject.Find ("Time");
		start_view = GameObject.Find ("start_view");
		bt_start = GameObject.Find ("bt_start");
		help = GameObject.Find ("Helper");
		chinese_first_sentence = GameObject.Find ("Chinese_sentence (0)");
		chinese_second_sentence = GameObject.Find ("Chinese_sentence (1)");
		chinese_third_sentence = GameObject.Find ("Chinese_sentence (2)");
		chinese_word = GameObject.Find ("Chinese_word");
		help_hint_view = GameObject.Find ("Help_hint_view");
		part_of_speech = GameObject.Find ("part_of_speech");
		//english_word = GameObject.Find ("English_word");
		bt_0_0 = GameObject.Find ("bt_send_0_0");
		bt_0_1 = GameObject.Find ("bt_send_0_1");
		bt_1_0 = GameObject.Find ("bt_send_1_0");
		bt_1_1 = GameObject.Find ("bt_send_1_1");
		bt_2_0 = GameObject.Find ("bt_send_2_0");
		bt_2_1 = GameObject.Find ("bt_send_2_1");
		bt_ai_correct = GameObject.Find ("bt_ai_correct");
		bt_ai_wrong = GameObject.Find ("bt_ai_wrong");
		bt_quit = GameObject.Find ("bt_quit");

		right_list_SV = GameObject.Find ("right_list/Scroll View");
		AI_card_SV = GameObject.Find ("AI_card/Scroll View");

		cluster = new GameObject[card_group_max];
		cluster_shadow_US = new UISprite[card_group_max];
		card_view_SV = new GameObject[sentence_max];
		for (int i = 0; i < sentence_max; i++) {
			card_view_SV [i] = GameObject.Find ("main_view/Scroll View ("+ i.ToString() +")");
		}

		cluster_UG = new UIGrid[card_group_max];//cluster垂直排列
		right_list_SV_UG = GameObject.Find("right_list/Scroll View").GetComponent<UIGrid>();
		AI_card_SV_UG = GameObject.Find ("AI_card/Scroll View").GetComponent<UIGrid> ();
		cluster_pos = new Transform[card_group_max];//cluster_pos位置

		for(int i =0; i < card_group_max; i++){
			eighty[i] = new string[card_group_number_max];
			card_turn_on [i]= new bool[card_group_number_max];
			card_answer_UL [i] = new UILabel [card_group_number_max];
			//card[i] = new GameObject[card_group_number_max];
			cluster [i] = GameObject.Find("cluster ("+i.ToString()+")");
			cluster_shadow_US [i] = GameObject.Find("cluster ("+i.ToString()+")/shadow").GetComponent<UISprite>();
			UIEventListener.Get (cluster[i]).onClick += ButtonClick;
			cluster_UG [i] = GameObject.Find("Scroll View/cluster ("+i.ToString()+")/bg_card").GetComponent<UIGrid>();
			cluster_pos[i] = GameObject.Find ("cluster ("+i.ToString()+")/bg_card").GetComponent<Transform>();
			is_turn_on [i] = false; 
		}

		card_time_cd_US = GameObject.Find ("card_time_cd").GetComponent<UISprite> ();
		computer_chance_US = GameObject.Find ("computer_chance").GetComponent<UISprite> ();
		//start_view_US = GameObject.Find ("start_view").GetComponent<UISprite> ();
		//bg_choose_view_US = GameObject.Find ("bg_choose_view").GetComponent<UISprite> ();


		Game_over_UL = GameObject.Find ("Game_over/Label").GetComponent<UILabel> ();
		bt_start_UL = GameObject.Find ("bt_start/Label").GetComponent<UILabel> ();
		time_UL = GameObject.Find ("Time/Label").GetComponent<UILabel> ();
		card_UL = GameObject.Find ("card_hint_view/Label_chinese_word").GetComponent<UILabel> ();
		bt_0_0_UL = GameObject.Find ("bt_send_0_0/Label").GetComponent<UILabel>();
		bt_0_1_UL = GameObject.Find ("bt_send_0_1/Label").GetComponent<UILabel>();
		bt_1_0_UL = GameObject.Find ("bt_send_1_0/Label").GetComponent<UILabel>();
		bt_1_1_UL = GameObject.Find ("bt_send_1_1/Label").GetComponent<UILabel>();
		bt_2_0_UL = GameObject.Find ("bt_send_2_0/Label").GetComponent<UILabel>();
		bt_2_1_UL = GameObject.Find ("bt_send_2_1/Label").GetComponent<UILabel>();
		Score_UL = GameObject.Find ("card_view/Score_Label").GetComponent<UILabel> ();
		AI_score_UL = GameObject.Find ("AI_view/AI_score_Label").GetComponent<UILabel>();
		hint_score_UL = GameObject.Find ("hint_score/Label").GetComponent<UILabel> ();
		helper_UL = GameObject.Find ("Helper/Label").GetComponent<UILabel> ();
		//chinese_sentence_UL = GameObject.Find ("Chinese_sentence/Label").GetComponent<UILabel> ();
		card_view_chinese_word_UL = GameObject.Find ("card_hint_view/Label_chinese_word").GetComponent<UILabel> ();
		hint_UL = GameObject.Find ("Help_hint_view/hint_Label").GetComponent<UILabel> ();
		card_time_cd_UL = GameObject.Find ("card_time_cd/Label").GetComponent<UILabel> ();
		AI_view_UL = GameObject.Find ("AI_view/Label").GetComponent<UILabel> ();
		start_view_UL = GameObject.Find ("start_view/Label").GetComponent<UILabel> ();
		start_view_UL_one = GameObject.Find ("start_view/Label (1)").GetComponent<UILabel> ();
		correct_UL = GameObject.Find ("card_view/correct_Label").GetComponent<UILabel> ();
		wrong_UL = GameObject.Find ("card_view/wrong_Label").GetComponent<UILabel> ();
		AI_correct_UL = GameObject.Find ("AI_view/AI_correct_Label").GetComponent<UILabel> ();
		AI_wrong_UL = GameObject.Find ("AI_view/AI_wrong_Label").GetComponent<UILabel> ();
		first_sentence_UL[0] = GameObject.Find ("first_sentence/Label (0)").GetComponent<UILabel> ();
		second_sentence_UL[1] = GameObject.Find ("second_sentence/Label (0)").GetComponent<UILabel> ();
		third_sentence_UL[2] = GameObject.Find ("third_sentence/Label (0)").GetComponent<UILabel> ();
		first_time_UL = GameObject.Find ("first_time/Label").GetComponent<UILabel> ();
		second_time_UL = GameObject.Find ("second_time/Label").GetComponent<UILabel> ();
		third_time_UL = GameObject.Find ("third_time/Label").GetComponent<UILabel> ();


		card_answer = Resources.Load ("card_answer")as GameObject;





		UIEventListener.Get (bt_quit).onClick += ButtonClick;
		UIEventListener.Get (bt_start).onClick += ButtonClick;
		UIEventListener.Get (help).onClick += ButtonClick;
		UIEventListener.Get (chinese_first_sentence).onClick += ButtonClick;
		UIEventListener.Get (chinese_second_sentence).onClick += ButtonClick;
		UIEventListener.Get (chinese_third_sentence).onClick += ButtonClick;
		UIEventListener.Get (chinese_word).onClick += ButtonClick;
		UIEventListener.Get (part_of_speech).onClick += ButtonClick;
		UIEventListener.Get (change_card).onClick += ButtonClick;
		//UIEventListener.Get (english_word).onClick += ButtonClick;

		UIEventListener.Get (bt_0_0).onClick += ButtonClick;
		UIEventListener.Get (bt_0_1).onClick += ButtonClick;
		UIEventListener.Get (bt_1_0).onClick += ButtonClick;
		UIEventListener.Get (bt_1_1).onClick += ButtonClick;
		UIEventListener.Get (bt_2_0).onClick += ButtonClick;
		UIEventListener.Get (bt_2_1).onClick += ButtonClick;

		//UIEventListener.Get (bt_ai_correct).onClick += ButtonClick;
		//UIEventListener.Get (bt_ai_wrong).onClick += ButtonClick;


		shield_method (false);
	}


		





	IEnumerator  delay_grid(int a,float t){

		yield return new WaitForSeconds (t);

		if (a == 0) {
			for (int i = 0; i < card_group_max; i++) {
				cluster_UG [i].Reposition ();
			}
		} else if (a == 1) {
			right_list_SV_UG.Reposition ();
		} else if (a == 2) {
			AI_card_SV_UG.Reposition ();
		} else if (a == 3 && let_go == false) {
			AI_send_cards ();
			let_go = true;
		} else if (a == 4) {
			AI_send_cards ();
		} 
	}







	void set_card(){
		
		string str = "";
		for(int i=0;i<3;i++){  //撈資料與切割字串
			str = d_obj.get_sentence_word(level ,i);

			int count =0;
			string temp ="";
			for(int k=0;k<str.Length;k++){
				
				if (str [k].ToString () != " ") {  //判斷空格
					temp += str [k];
				} else {
					sentence [i] [count] = temp;
					//print (sentence [i] [count]);
					count += 1;
					temp = "";

				}
			}

		}
		/////////////////////////////////////////////////////把17陣列給16陣列  (重要)
		bool key = false;

		for (int i = 0; i < 3; i++) {
				key = false;
			for(int j = 0 ; j < sentence_max-1 ; j ++ ){
				
				if (j == d_obj.get_key_word (i)) {
					key = true;
				}
					if (key == false) {
						no_key_word [i] [j] = sentence [i] [j];

					} else {
						no_key_word [i] [j] = sentence [i] [j + 1];
					//print (no_key_word [i] [j]);
					}
				}

			}

		//////////////////////////////////////////////////////






		///設定48張卡片
		int var =0;
		int var_c = 0;
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < sentence_max-1; j ++) {
				if (i != 1) {
					if (j % 2 == 0) {
						even_odd_even [var] = no_key_word [i] [j];

						var += 1;

					} else {
						odd_even_odd [var_c] = no_key_word [i] [j];
						var_c += 1;
					}
				} else {
					if (j % 2 == 1) {
						even_odd_even [var] = no_key_word [i] [j];

						var += 1;
					} else {
						odd_even_odd [var_c] = no_key_word [i] [j];
						var_c += 1;
					}
				
				}

				/*if (i != 1) {
					if (j % 2 == 1) {
						

						var_c += 1;
					}
				} else {
					if(j % 2 == 0){
						odd_even_odd[var_c] = no_key_word[i][j];

						var_c += 1;
					}
				}

				print (var_c);*/



			}
		}
		/*int var_c = 0;

			for (int j = 0; j < sentence_max; j += 2) {
			

				}
			}*/

		//////////////////////////////////////////////////////////




		for(int i =0; i < card_valid_max / 2  ; i++){   //隨機交換48張卡牌位置
			int r = UnityEngine.Random.Range( 0,  card_valid_max / 2);
			int n = UnityEngine.Random.Range( 0,  card_valid_max / 2);
			string temp_x = even_odd_even[i];
			even_odd_even [i] = even_odd_even [r];
			even_odd_even [r] = temp_x;

			string temp_y = odd_even_odd[i];
			odd_even_odd [i] = odd_even_odd [r];
			odd_even_odd [r] = temp_y;


		}


	



		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			 
		  
			int count_a =0;
			string temp_a ="";
			for(int k=0;k<str.Length;k++){         //切割無效卡牌字串與撈資料
				
				str = d_obj.get_invalid_word(level);
					
				if (str [k].ToString () != " ") {  //判斷空格
					temp_a += str [k];
				} else {
					twenty[count_a] = temp_a;
					count_a += 1;
					temp_a = "";

				}
			}
			



		for(int i =0; i < card_invalid_max ;i++){   //隨機交換20張無效卡牌位置
			int r = UnityEngine.Random.Range( 0,  card_invalid_max );
			string temp = twenty[i];
			twenty [i] = twenty [r];
			twenty [r] = temp;
		}


		/*for(int i =0; i< (card_valid_max/card_group_max) ;i++ ){  //80陣列放入60陣列
			for(int j=0; j < card_group_max ; j++ ){
				eighty[i][j] = sixty[var] ;
				var += 1 ;
			}
		}

		for(int i =0; i< (card_invalid_max/card_group_max)  ;i++ ){  //80陣列放入20陣列
			for(int j=0; j < card_group_max ; j++ ){
				 eighty[i][j] = twenty[var] ;
				 var += 1 ;
			}
		}



		for(int i =0; i< 8 ;i++ ){  //80二維陣列放入80陣列
			for(int j=0; j < 10 ; j++ ){
				eighty_array[var] = eighty[i][j] ;
				var += 1 ;
			}
		}*/

		int var_a = 0;
		int var_d = 0;

		for (int i = 0; i < (card_group_max / 2); i++) {
			for (int j = 0; j < (card_valid_max / card_group_max); j++) {
				eighty [i] [j] = even_odd_even [var_a];//把60陣列放入80二維陣列
					var_a += 1;
			}
		}

		for (int i = (card_group_max / 2); i < card_group_max; i++) {
			for (int j = 0; j < (card_valid_max / card_group_max); j++) {
				eighty [i] [j] = odd_even_odd [var_d];//把60陣列放入80二維陣列
				var_d += 1;
			}
		}

		/*for (int i = 0; i < 8; i++) {//s型排序字串(機率相同)
			for (int j = 0 ; j < 6; j += 2 ) {
				
				eighty [i] [j] = sixty [(j*8)+i];


			}

			for (int k = 1; k < 6; k += 2) {
				
				eighty [i] [k] = sixty [(8 * (k + 1) - i - 1)];

				


			}
		}*/




	
		int var_b = 0;
		for (int i = 0; i < card_group_max; i++) {
			for (int j = (card_valid_max / card_group_max); j < card_group_number_max; j++) {
				eighty[i][j] = twenty[var_b];//把20陣列放入80二維陣列
				var_b += 1;
				
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////組別裡面隨機交換

		for (int j = 0; j < card_group_max; j++) {
			for (int i = 0; i < card_group_number_max; i++) {   //第一組8張卡隨機交換卡牌位置
				int r = UnityEngine.Random.Range (0, card_group_number_max);
				string temp = eighty [j] [i];
				eighty [j] [i] = eighty [j] [r];
				eighty [j] [r] = temp;
			
			}
		}
		/*for (int k = 0; k < card_group_max; k++) {
			string temp = "";
			int r = UnityEngine.Random.Range (0, card_group_max);
			for (int i = 0; i < card_group_number_max; i++) {
				temp = eighty [k] [i];
				eighty [k] [i] = eighty [r] [i];
				eighty [r] [i] = temp
			}


		}*/
		/*for (int j = 0; j < card_group_max; j++) {
			int r = UnityEngine.Random.Range (0, card_group_max);
			for (int i = 0; i < card_group_number_max; i++) {   
				string temp_b = eighty [j] [i];
				eighty [j] [i] = eighty [r] [i];
				eighty [r] [i] = temp_b;

			}
		}*/
		//////////////////////////////////////////////////////////////////////////////////////////////////////



		//int countnum_a = 0;
		//int countnum_b = 0;
		for (int i = 0; i < card_group_max; i++) { //生卡牌
			//GameObject.Find("cluster ("+i.ToString()+")/Label").GetComponent<UILabel>().text = "第"+(i+1).ToString()+"組";

			for (int j = 0; j < card_group_number_max; j++) {


				born_card(i, j, eighty[i][j],0);
				/*if (j <7) {
					born_card_j += 1;
				} else  {
					born_card_j = 0;
					born_card_i += 1;
				}*/

			}
		}





	}


	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






	void key_word(){
		//string str = "";
		//str = d_obj.get_sentence_word (level,0);
		//str [d_obj.get_key_word (0)];
		/*for (int i = 0; i < 3; i++) {
			//sentence [i] [d_obj.get_key_word (i)];
			born_card (i,d_obj.get_key_word (i),sentence [i] [d_obj.get_key_word (i)],2);
		}*/
		for (int i = 0; i < 3; i++) {
			//sentence [i] [d_obj.get_key_word (i)];
			answer_str [i] = "[c][ff0000ff]" + sentence [i] [d_obj.get_key_word (i)] + "[-][/c]";
			GameObject.Find("bg ("+i.ToString()+")/Label").GetComponent<UILabel>().text=  answer_str [i];

		}
		/*for (int i = 0; i < 3; i++) {
			for (int j = 0; j < sentence_max; j++) {
				born_card (i, j, sentence [i] [j], 2);
			}
		}*/
			


	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////以下ai部分
	void card_correct(){  //AI正確卡部分
		GameObject []AI_cards = FindGameObjectsWithName("AI_card_answer");

		AI_isfind = false;
		//int a = 0;
		//if(last_num_i != -1){
		for(int n = 0 ; n < AI_cards.Length ; n++){
			if (AI_isfind)   break;
			for (int i = 0; i < 3; i++) {
				if (AI_isfind)   break;
				for (int j = 0; j < 2; j++) {
					if (AI_isfind)
						break;
					/*if (card_index [j] [i] == 0 && card_index [j] [i] == 16) {  //game over
					print("ai_over");
					Game_over.transform.localPosition = new Vector3(0 , 0 , 0);//Game over
					}*/


			//	if (card_index [j] [i] < (sentence_max - 1) && card_index [j] [i] > 0){
				print ("card_index"+card_index [j] [i].ToString()+","+i.ToString()+","+j.ToString());
					if (sentence_isover [j] [i] == false) {
						if (AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == sentence [i] [card_index [j] [i]]) { //AI答對

							AI_view_UL.text = "電腦答對:\n" + sentence [i] [card_index [j] [i]];

							if (j == 0 && card_index [j] [i] < (sentence_max - 1)) {	//往右
								answer_str [i] = answer_str [i] + " " + "[c][FFFF00FF]" + sentence [i] [card_index [j] [i]] + "[-][/c]";//ex:aaa10 aaa11
								card_index [j] [i] += 1;
						
							} else if (j == 0 && card_index [j] [i] == (sentence_max - 1)) {
								print ("213");
								if (i == 0) {
									r_1 = true;
								} else if (i == 1) {
									r_2 = true;
								} else if (i == 2) {
									r_3 = true;
								}

								//if (sentence_isover [j] [i] == false) {
									answer_str [i] = answer_str [i] + " " + "[c][FFFF00FF]" + sentence [i] [card_index [j] [i]] + "[-][/c]";//ex:aaa10 aaa11
									sentence_isover [j] [i] = true;
									//Destroy(GameObject.Find("bt_send_" + last_bt_num_i.ToString() + "_" + last_bt_num_j.ToString()));
									GameObject.Find ("bt_send_" + i.ToString () + "_" + j.ToString ()).transform.localPosition = new Vector3 (3000, 0, 0);//當句子到底時，隱藏按鈕

								//}
							}





							if (j == 1 && card_index [j] [i] > 0) {	//往左
								answer_str [i] = "[c][FFFF00FF]" + sentence [i] [card_index [j] [i]] + "[-][/c]" + " " + answer_str [i];//ex:aaa9 aaa10
								card_index [j] [i] -= 1;
							} else if (j == 1 && card_index [j] [i] == 0) {
								print ("231");

								if (i == 0) {
									l_1 = true;
								} else if (i == 1) {
									l_2 = true;
								} else if (i == 2) {
									l_3 = true;
								}

								//if (sentence_isover [j] [i] == false) {
									answer_str [i] = "[c][FFFF00FF]" + sentence [i] [card_index [j] [i]] + "[-][/c]" + " " + answer_str [i];//ex:aaa9 aaa10
									sentence_isover [j] [i] = true;
									//Destroy(GameObject.Find("bt_send_" + last_bt_num_i.ToString() + "_" + last_bt_num_j.ToString()));
									GameObject.Find ("bt_send_" + i.ToString () + "_" + j.ToString ()).transform.localPosition = new Vector3 (3000, 0, 0);//當句子到底時，隱藏按鈕


								//}


							} 
						

							answer_UL [i].text = answer_str [i];
							Destroy (AI_cards [n]);
						
							AI_isfind = true;
							
						


							check_over ();
							print ("AI_correct");
							AI_correct_count += 1; 
						}
						//}

					}




					}
				}

			}
			if (AI_isfind == false) {  //當ai找不到正確的卡牌時，強制執行錯誤
				correct_sum -= 2;
				card_wrong ();
				print ("AI_no_correct_card");
			}	
			GameObject.Find ("AI_view/Label").GetComponent<TweenScale>().Toggle();

			
		}





	void card_wrong(){ //AI錯誤卡部分
		GameObject []AI_cards = FindGameObjectsWithName("AI_card_answer");
		bool AI_wrong_isfind;
		bool AI_is_pos_wrong = true;
		AI_wrong_isfind = false;
		for (int n = 0; n < AI_cards.Length; n++) {
			if (AI_wrong_isfind)   break;

		for (int i = 0; i < card_invalid_max; i++) { 
				if (AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == twenty [i]) {
					AI_is_pos_wrong = false;

				} 
			}
			if (AI_is_pos_wrong) {
				AI_view_UL.text = "電腦答錯!!";
				print ("AI_pos_wrong");
				AI_score -= 20;
				AI_wrong_count += 1;
			} else {
				AI_view_UL.text = "電腦答錯!!";
				print ("AI_wrong");
				Destroy (AI_cards[n]);
				AI_score -= 10;
				AI_wrong_count += 1;
			}

			
			AI_wrong_isfind = true;
		}
		check_over ();
		GameObject.Find ("AI_view/Label").GetComponent<TweenScale>().Toggle();
	}


	void AI_send_cards(){ //AI:50%答對/50%答錯
		//int correct_sum = 0;
		//int wrong_sum = 0;
		if (correct_sum == card_correct_max && wrong_sum == card_wrong_max) {
			wrong_sum = 0;
			correct_sum = 0;
		}
		int r = UnityEngine.Random.Range (0, 100);
		if (r < 50) {
			AI_correct ();
		} else {
			AI_wrong ();
		}
		
	

	}
	void AI_correct(){
		if (correct_sum < card_correct_max) {
			card_correct ();
			correct_sum += 1;
		} else {
			
			AI_wrong ();
		}
	}

	void AI_wrong(){
		if (wrong_sum < card_wrong_max) {
			card_wrong ();
			wrong_sum += 1;
		} else {
			
			AI_correct ();
		}
	}
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////以上ai部分

	public void born_card(int num ,int pos,string str,int seat){
		GameObject obj = (GameObject)Instantiate (card_answer as GameObject, new Vector3 (0, 0, 0), Quaternion.identity);


		if(seat == 0){
			obj.transform.parent = cluster_pos [num];//cluster的位置
			obj.name = "card_" + num.ToString ()+"_"+pos.ToString();
			//obj.gameObject.transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = str;
			obj.GetComponent<BoxCollider> ().enabled = false;

		}else if(seat ==1){
			obj.transform.parent = right_list_SV.transform;//right_list_SV的位置
			//card_answer_UL [num] [pos] = obj.gameObject.transform.Find ("Label").gameObject.GetComponent<UILabel> ();
			obj.name = "card_answer" + num.ToString ()+"_"+pos.ToString();
			//card_answer_UL [num] [pos].text = str;
			//obj.gameObject.transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = str;
			UIEventListener.Get (obj).onClick += ButtonClick;
		

		}else if(seat == 2){
			
			//main_view_SV [num] [pos] = GameObject.Find("main_view ("+num.ToString()+")/Scroll View ("+pos.ToString()+")");
			//print (num.ToString()+","+pos.ToString());
			obj.transform.parent = AI_card_SV.transform;//main_view_SV的位置
			//obj.GetComponent<BoxCollider>().enabled = false;
			obj.name = "AI_card_answer" + num.ToString ()+"_"+pos.ToString();

			//obj.gameObject.transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = str;
		}
		obj.gameObject.transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = str;
		obj.transform.localRotation = transform.localRotation;
		obj.transform.localScale = new Vector3 (1f, 1f, 1f);
		obj.transform.localPosition = new Vector3 (0f, 0f, 0f);





	
	}



	GameObject[] FindGameObjectsWithName(string str){
		int a = GameObject.FindObjectsOfType <GameObject>().Length;
		GameObject[] arr=new GameObject[a];
		int FluentNumber = 0;
		for (int i=0; i<a; i++) {
			if (GameObject.FindObjectsOfType<GameObject> () [i].name.StartsWith(str)) {
				arr [FluentNumber] = GameObject.FindObjectsOfType<GameObject> () [i];
				FluentNumber++;
			}
		}
		//Array.Resize (ref arr, FluentNumber);

		GameObject[] arr1=new GameObject[FluentNumber];
		for (int i = 0; i < FluentNumber; i++) {
			arr1 [i] = arr [i];
		}
		return arr1;
	}




	public void send_CD(){    //玩家出牌後鎖定3秒cd
		


		player_cd = false;
		card_time_cd_US.color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//出現
		computer_chance_US.color = new Vector4 (180f / 255f, 180f / 255f, 180f / 255f, 255f / 255f);//出現
		card_time_cd_UL.text = send_cd_count.ToString();

		send_cd_count -= 1;



		if (send_cd_count <= -1) {
			card_time_cd_US.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
			computer_chance_US.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
			CancelInvoke ("send_CD");
			send_cd_count = 3;
			player_cd = true;

			}
			
	}


	 void check_over(){
		GameObject[] cards = FindGameObjectsWithName ("card_answer");

		if (r_1 == true && r_2 == true && r_3 == true && l_1 == true && l_2 == true && l_3 == true) {
		tx.WriteToFile0 (time_UL.text, "玩家分數: "+ score.ToString() );
		tx.WriteToFile0 (time_UL.text, "電腦分數: "+ AI_score.ToString());
		tx.WriteToFile0 (time_UL.text, "提示分數: "+ hint_score.ToString());


		Game_over.transform.localPosition = new Vector3(0 , 0 , 0);//Game over
			

	}
		



		print ("目前手牌剩餘數量:" + (cards.Length).ToString());
		if (cards.Length == 0) {
			
		tx.WriteToFile0 (time_UL.text, "玩家分數: "+ score.ToString() );
		tx.WriteToFile0 (time_UL.text, "電腦分數: "+ AI_score.ToString());
		tx.WriteToFile0 (time_UL.text, "提示分數: "+ hint_score.ToString());

		//card_UL.GetComponent<TweenScale>().Toggle();
			//card_UL.text = "[c][ff0000ff]Game over[-][/c]";
			GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "";
			Game_over.transform.localPosition = new Vector3(0 , 0 , 0);//Game over
		}

	}


	void shield_method (bool b){
		shield = b;
		if (shield == true) {
			GameObject.Find("shield_shadow/Shield").GetComponent<UISprite>().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);//出現
		} else {
			
			GameObject.Find("shield_shadow/Shield").GetComponent<UISprite>().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
		}
	}


	void quit (){	
		Application.Quit ();
		} 


	public void ButtonClick(GameObject obj){
		string s = obj.name;

		//print (s);

		if (s.StartsWith ("bt_quit")) {
			print ("over");

		tx.WriteToFile0 (time_UL.text, "E");	
		quit ();
	}


		if (s.StartsWith ("bt_start")) {
			if (card_light_count == 4) {
				
				//start = true;
				is_start = true;
				tx.WriteToFile0 (time_UL.text, "B");

				//start_view_US.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
				//bg_choose_view_US.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
				GameObject.Find ("bg_startview").GetComponent<TweenPosition> ().Toggle ();


				for (int i = 0; i < card_group_max; i++) { //生卡牌
					if (is_turn_on [i] == true) {
						for (int j = 0; j < card_group_number_max; j++) {
							born_card (i, j, eighty [i] [j], 1);

						}
					}
						
				}

					
				for (int i = 0; i < card_group_max; i++) { //生卡牌
					if (is_turn_on [i] == false) {
						for (int j = 0; j < card_group_number_max; j++) {
							born_card (i, j, eighty [i] [j], 2);

						}
					}

				}

					
				StartCoroutine (delay_grid (1, 0.2f));
				StartCoroutine (delay_grid (2, 0.2f));
			} else {
				GameObject.Find ("start_view/Label").GetComponent<TweenScale> ().Toggle ();
				start_view_UL.text = "無法開始";
			}

			key_word ();

			//////////////////////////////////////////////////////////////////////////////////////整理手牌

			GameObject[] cards = FindGameObjectsWithName ("card_answer");

			string[] str = new string[cards.Length];

			for (int i = 0; i < cards.Length; i++) {
				str [i] = cards [i].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text;
				//str[i]= str[i].ToLower();
			}
			string temp = "";

			for (int j = 0; j < cards.Length; j++) {
				for (int i = 0; i < cards.Length - 1; i++) {
					
					if (str [i].ToLower() [0] < str [i + 1].ToLower() [0]) {
						temp = str [i];
						str [i] = str [i + 1];
						str [i + 1] = temp;
						
					}







				}
			}
			for (int i = 0; i < cards.Length; i++) {
				//print (str [i]);
				cards [i].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = str [i];
			}
		}
			
	

		



		if (s.StartsWith ("cluster (")) {
			int n = int.Parse (s [9].ToString ());
			

			if (n == 0 || n == 1 || n == 2 || n == 3) {
				for (int i = 0; i < 8; i++) {
					cluster_shadow_US [i].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster全關掉
					card_light_count = 0;
					is_turn_on [i] = false;
				}
				for (int i = 0; i < 4; i++) {
					cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮
				tx.WriteToFile0 (time_UL.text, (i+1).ToString());
					is_turn_on [i] = true;
					card_light_count += 1;
				}
			} else {
				for (int i = 0; i < 8; i++) {
					cluster_shadow_US [i].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster全關掉
					card_light_count = 0;
					is_turn_on [i] = false;
				}
				for (int i = 4; i < 8; i++) {
					cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮
					tx.WriteToFile0 (time_UL.text, (i+1).ToString());
					is_turn_on [i] = true;
					card_light_count += 1;
				}
		}



			/*if (is_turn_on [n] == false) {
				
				if (n == 0 || n == 1 || n == 2 || n == 3) {
					for (int i = 0; i < 4; i++) {
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮
						
						is_turn_on [i] = true;
						card_light_count += 1;	
						
					}
					for (int j = 4; j < 8; j++) {
						cluster_shadow_US [j].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster關掉
						is_turn_on [j] = false;
						card_light_count -= 1;
					}
					print ("1");
					
				} else {
					for (int i = 4; i < 8; i++) {
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮

						is_turn_on [i] = true;
						card_light_count += 1;
					}
					for (int j = 0; j < 4; j++) {
						cluster_shadow_US [j].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster關掉
						is_turn_on [j] = false;
						card_light_count -= 1;
					}
					print ("2");
					
				}
			} else if(is_turn_on[n] == true){
				
				if (n == 0 || n == 1 || n == 2 || n == 3) {
					for(int i = 0 ; i < 4 ; i++){
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮
					}
					for (int i = 0; i < 4; i++) {
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster關掉
						is_turn_on [i] = false;
						card_light_count -= 1;
				}
					
					print ("3");
					
				} else {
					for(int i = 4 ; i < 8 ; i++){
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//cluster點亮
					}
					for (int i = 4; i < 8; i++) {
						cluster_shadow_US [i].color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//cluster關掉
						is_turn_on [i] = false;
						card_light_count -= 1;
				}
					
				print ("4");
				}*/
			


			
			if (card_light_count == 0) {
				GameObject.Find ("start_view/Label (1)").GetComponent<TweenScale> ().Toggle ();
				start_view_UL_one.text = "請選擇卡牌";
			}


		}

		if (player_cd == true) {
			if (s.StartsWith ("card_answer")) {
				
				tx.WriteToFile0 (time_UL.text,"C");

				if (last_num_i != -1 && last_num_j != -1) {  //一開始不等於-1  全關
					GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//全關
				}


				if (last_num_i == int.Parse (s [11].ToString ()) && last_num_j == int.Parse (s [13].ToString ())) {
					last_num_i = -1;
					last_num_j = -1;
				} else {
					obj.transform.Find ("shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);//開燈

					last_num_i = int.Parse (s [11].ToString ());
					//last_num_j = int.Parse (s [13].ToString ());
					//if (s.Length > 1) {
					last_num_j = int.Parse (s .Substring(13).ToString ());
					//} else {
					//last_num_j = int.Parse (s [13].ToString ());
				//}

				print ("last_num_i:"+last_num_i.ToString()+",last_num_j:"+last_num_j.ToString()+", s.Length:" + s.Length);
			
				}




				/*if (last_num_i == int.Parse (s [11].ToString ()) && last_num_j == int.Parse (s [13].ToString ())) {
				last_num_i = -1;
				last_num_j = -1;
				
				obj.transform.Find ("shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);
			} else {
				obj.transform.Find ("shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);

			}

			if (last_num_i != -1 && last_num_j != -1) {
				GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);

			}
*/





			}
		}

		if (player_cd == true && let_go == true) {
			if (s.StartsWith ("bt_send_")) {
				check_over ();

				if (last_num_i == -1 && last_num_j == -1) {
					GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
					GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "請先選擇卡牌";
				} else {
					/*string str = "";
			str = d_obj.get_invalid_word (0);*/ 

					//Invoke ("ABC()",0.2f);
					//Invoke ("send_CD()",1);


				


					last_bt_num_i = int.Parse (s [8].ToString ());
					last_bt_num_j = int.Parse (s [10].ToString ());


					if (last_bt_num_i == 0 && last_bt_num_j == 0)
						tx.WriteToFile0 (time_UL.text, "K");
					if (last_bt_num_i == 0 && last_bt_num_j == 1)
						tx.WriteToFile0 (time_UL.text, "U");
					if (last_bt_num_i == 1 && last_bt_num_j == 0)
						tx.WriteToFile0 (time_UL.text, "J");
					if (last_bt_num_i == 1 && last_bt_num_j == 1)
						tx.WriteToFile0 (time_UL.text, "I");
					if (last_bt_num_i == 2 && last_bt_num_j == 0)
						tx.WriteToFile0 (time_UL.text, "G");
					if (last_bt_num_i == 2 && last_bt_num_j == 1)
						tx.WriteToFile0 (time_UL.text, "O");
				
					
						if (last_num_i != -1) { //判斷句子  bt_send_(last_bt_num_i)_(last_bt_num_j)
						
							string click_str = GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text;


							if (click_str == sentence [last_bt_num_i] [card_index [last_bt_num_j] [last_bt_num_i]]) { //答對



								/*if (card_index [last_bt_num_j] [last_bt_num_i] == 0 && card_index [last_bt_num_j] [last_bt_num_i] == 16) {  //game over
								//GameObject.Find ("card_view/Label").GetComponent<TweenScale>().Toggle();
								print("player_over");
								Game_over.transform.localPosition = new Vector3 (0, 0, 0);//Game over
							}*/
					
								if (last_bt_num_j == 0 && card_index [last_bt_num_j] [last_bt_num_i] < (sentence_max - 1)) {	//往右
									answer_str [last_bt_num_i] = answer_str [last_bt_num_i] + " " + sentence [last_bt_num_i] [card_index [last_bt_num_j] [last_bt_num_i]];//ex:aaa10 aaa11
									card_index [last_bt_num_j] [last_bt_num_i] += 1;

								} else if (card_index [last_bt_num_j] [last_bt_num_i] == (sentence_max - 1)) {
									print ("321");
									if (last_bt_num_i == 0) {
										r_1 = true;
									} else if (last_bt_num_i == 1) {
										r_2 = true;
									} else if (last_bt_num_i == 2) {
										r_3 = true;
									}

							if(sentence_isover[last_bt_num_j][last_bt_num_i] == false){
									answer_str [last_bt_num_i] = answer_str [last_bt_num_i] + " " + sentence [last_bt_num_i] [card_index [last_bt_num_j] [last_bt_num_i]];//ex:aaa10 aaa11

									sentence_isover [last_bt_num_j] [last_bt_num_i] = true;
									//card_index [last_bt_num_j] [last_bt_num_i] += 1;
									//Destroy(GameObject.Find("bt_send_" + last_bt_num_i.ToString() + "_" + last_bt_num_j.ToString()));
									GameObject.Find ("bt_send_" + last_bt_num_i.ToString () + "_" + last_bt_num_j.ToString ()).transform.localPosition = new Vector3 (3000, 0, 0);//當句子到底時，隱藏按鈕
									}
								
								}



								if (last_bt_num_j == 1 && card_index [last_bt_num_j] [last_bt_num_i] > 0) {	//往左
									answer_str [last_bt_num_i] = sentence [last_bt_num_i] [card_index [last_bt_num_j] [last_bt_num_i]] + " " + answer_str [last_bt_num_i];//ex:aaa9 aaa10
									card_index [last_bt_num_j] [last_bt_num_i] -= 1;

								} else if (card_index [last_bt_num_j] [last_bt_num_i] == 0) {
									print ("123");
									if (last_bt_num_i == 0) {
										l_1 = true;
									} else if (last_bt_num_i == 1) {
										l_2 = true;
									} else if (last_bt_num_i == 2) {
										l_3 = true;
									}
								
								if (sentence_isover [last_bt_num_j] [last_bt_num_i] == false) {
									answer_str [last_bt_num_i] = sentence [last_bt_num_i] [card_index [last_bt_num_j] [last_bt_num_i]] + " " + answer_str [last_bt_num_i];//ex:aaa9 aaa10

									sentence_isover [last_bt_num_j] [last_bt_num_i] = true;
									//card_index [last_bt_num_j] [last_bt_num_i] -= 1;
									//Destroy(GameObject.Find("bt_send_" + last_bt_num_i.ToString() + "_" + last_bt_num_j.ToString()));
									GameObject.Find ("bt_send_" + last_bt_num_i.ToString () + "_" + last_bt_num_j.ToString ()).transform.localPosition = new Vector3 (3000, 0, 0);//當句子到底時，隱藏按鈕
							
									}
								}
								answer_UL [last_bt_num_i].text = answer_str [last_bt_num_i];
								Destroy (GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString ()));
								last_num_i = -1;
								last_num_j = -1;
								StartCoroutine (delay_grid (1, 0.2f));


								if (let_go == true) {
									StartCoroutine (delay_grid (3, 2.0f));
									let_go = false;
								}
								GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
								GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "玩家答對!!";
								print ("correct");
								tx.WriteToFile0 (time_UL.text, "Y");


								print ("旗幟:" + card_index [last_bt_num_j] [last_bt_num_i]);

								correct_count += 1;

					
							} else { //答錯
								bool is_pos_wrong = true;
								for (int i = 0; i < card_invalid_max; i++) { 
									if (click_str == twenty [i]) {
										is_pos_wrong = false;

									} 
								}
								if (is_pos_wrong) {//位置錯誤
									tx.WriteToFile0 (time_UL.text, "P");
									GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//關燈
									GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
									GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "玩家答錯!!";
									if (shield == false) {
										score -= 20;
									} else {
										shield_method (false);
										GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "玩家答錯!!\n刪除護盾";
									}
									last_num_i = -1;
									last_num_j = -1;
								} else { //雜牌錯誤
									tx.WriteToFile0 (time_UL.text, "W");
									Destroy (GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString ()));
									last_num_i = -1;
									last_num_j = -1;
									StartCoroutine (delay_grid (1, 0.5f));
									GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
									GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "玩家答錯!!\n刪除非答案卡";

									if (shield == false) {
										score -= 10;
									} else {
										shield_method (false);
										GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "玩家答錯!!\n刪除護盾";
									}
								}
							
								if (let_go == true) {
									StartCoroutine (delay_grid (3, 2.0f));
									let_go = false;
								}
								print ("wrong"); 
								wrong_count += 1;

							}

						
							InvokeRepeating ("send_CD", 0, 1);//0秒開始做,每秒做1次
						}





					/*	if (last_bt_num_j == 1 && last_num_i != -1) { //判斷句子左邊(負)
				string click_str = GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text;
				if (click_str == sentence [last_bt_num_i] [xl[last_bt_num_i]]) {


					
					answer_UL [last_bt_num_i].text = answer_str [last_bt_num_i];
					
						xl[last_bt_num_i] -= 1;
						Destroy (GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString ()));
						last_num_i = -1;
						last_num_j = -1;
						StartCoroutine (delay_grid (1, 0.2f));
						print ("correct");

				} else {
					bool is_pos_wrong = true;
					for (int i = 0; i < 20; i++) { 
						if (click_str == twenty [i]) {
							is_pos_wrong = false;

						} 
					}
					if (is_pos_wrong) {

						score -= 20;
					} else {

						//destory
						score -= 10;
					}
					print ("wrong");
				}
			}*/
				

				


				}
			}
		}

		if (player_cd == true) {
			if (s.StartsWith ("change_card")) {

				


				if (last_num_i == -1 && last_num_j == -1) {
					GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
					GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "請先選擇卡牌";

				} else {
					tx.WriteToFile0 (time_UL.text, "Q");
					hint_score -= 20;
					string[] arr;
					arr = new string[2];
					string click_str = GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text;
					//GameObject[] cards = FindGameObjectsWithName ("card_answer");
					GameObject[] AI_cards = FindGameObjectsWithName ("AI_card_answer");
					
					
					arr [0] = click_str;
					string[] AI_cards_str = new string[AI_cards.Length];
					for (int n = 0; n < AI_cards.Length; n++) {
					AI_cards_str[n] = AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text;
				}

					
					int unuse_sum = 0; 
					for (int n = 0; n < AI_cards.Length; n++) {
					for (int i = 0; i < twenty.Length; i++) {
						//print (AI_cards_str [n] + " VS " + twenty [i]);
							if (AI_cards_str [n] == twenty [i]) {
								//print ("X card: " + AI_cards_str [n]);
								AI_cards_str [n] = "null";
								unuse_sum += 1;
								break;
							}
						}
					}

					string[] AI_cards_str_new = new string[AI_cards.Length-unuse_sum];
					int count = 0;
					for (int n = 0; n < AI_cards.Length ; n++) {
						if (AI_cards_str [n] != "null") {
							AI_cards_str_new [count] = AI_cards_str [n];
							count += 1;
						}
				}
					if (count == 0) {
						hint_score += 20;
						card_view_chinese_word_UL.text = "換牌失敗: 電腦沒有正確卡牌!!"; 
					} else {
						int ran_index = 0;
						string str = AI_cards_str_new [0];
						bool different = false;
						for (int n = 0; n < AI_cards_str_new.Length; n++) {
							if (str != AI_cards_str_new[n]) {
								different = true;
						}
					}
						if (different) {
							if (AI_cards_str_new.Length > 2) {
								for (int n = 0; n < AI_cards_str_new.Length; n++) {
								int ran = UnityEngine.Random.Range (0, AI_cards_str_new.Length);
								ran_index = ran;
									if (last_change_card != AI_cards_str_new [ran]) {
									arr [1] = AI_cards_str_new [ran];
										
									break;
								}
							}

								
							} else {
							int ran = UnityEngine.Random.Range (0, AI_cards_str_new.Length);
							arr [1] = AI_cards_str_new [ran];
								ran_index = ran;
						}
						} else {
						int ran = UnityEngine.Random.Range (0, AI_cards_str_new.Length);
						arr [1] = AI_cards_str_new [ran];
						ran_index = ran;
					}
					last_change_card = arr [1];
					/*int ran = UnityEngine.Random.Range (0, AI_cards_str_new.Length);
					arr [1] = AI_cards_str_new [ran];*/

					GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text = arr [1];
					for(int i=0;i<AI_cards.Length;i++){
							if (AI_cards [i].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == AI_cards_str_new [ran_index]) {
							AI_cards [i].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = arr [0];
							break;
						}
					}
					//AI_cards [ran_index].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = arr [0];
					print ("換牌後電腦手牌:" + arr [0]);
					card_view_chinese_word_UL.GetComponent<TweenScale> ().Toggle ();
					card_view_chinese_word_UL.text = "換牌成功: " + arr [0] + "-->" + arr [1]; 
				}
					

					/*for (int n = 0; n < AI_cards.Length; n++) {
					if (AI_card_isfind)
						break;
						for (int i = 0; i < 3; i++) {
						if (AI_card_isfind)
							break;
							for (int j = 0; j < 2; j++) {

								if (AI_card_isfind)
									break;


								if (AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == sentence [i] [j]) { //AI答對


									
									arr [1] = AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text;

									AI_card_isfind = true;

									AI_cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text = arr [0];

								} else {
									//card_view_chinese_word_UL.text = "換牌失敗: 電腦沒有正確卡牌!!"; 
								}
							}
						}

						GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text = arr [1];

						print ("原本電腦手牌:" + arr [1]);
			




						print ("換牌後電腦手牌:" + arr [0]);
						card_view_chinese_word_UL.GetComponent<TweenScale> ().Toggle ();
						card_view_chinese_word_UL.text = "換牌成功: " + arr [0] + "-->" + arr [1]; 
					}*/



				}
			}

		}















		if (player_cd == true) {
			if (s.StartsWith ("Helper")) {
				hint_score -= 50;



				/*if(GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text == sentence [0] [] ){
				GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 0f / 255f, 255f / 255f);
			}*/
				
				GameObject[] cards = FindGameObjectsWithName ("card_answer");

				print (cards.Length);
				isfind = false;
				string str = "";
				string[] arr;
				arr = new string[5];
				int a = 0;


				if (cards.Length > 4) {
					tx.WriteToFile0 (time_UL.text,"H");
					shield_method (true);
					GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "開啟護盾";
					int ran = UnityEngine.Random.Range (0, cards.Length);
					for (int n = ran; n < cards.Length; n++) {
						if (isfind)
							break;

						for (int i = 0; i < 3; i++) {
							for (int j = 0; j < 2; j++) {

								//print ("n = "+n.ToString () +",i ="+ i.ToString () +", j = "+ j.ToString ()+", card_index = "+card_index[j][i].ToString());

							if (card_index [j] [i] < (sentence_max - 1) && card_index [j] [i] > 0) { 
									if (cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == sentence [i] [card_index [j] [i]]) {
										//print (sentence [i] [card_index [j] [i]]);
										arr [0] = sentence [i] [card_index [j] [i]];
										a = n;
										print (arr [0]);
										//card_UL.text = str; 
										isfind = true;
									}
								}
							}
						}

					}
					if (isfind == false) {
						for (int n = 0; n < ran; n++) {
							if (isfind)
								break;

							for (int i = 0; i < 3; i++) {
								for (int j = 0; j < 2; j++) {
									
								if (card_index [j] [i] < (sentence_max - 1) && card_index [j] [i] > 0) {
										if (cards [n].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == sentence [i] [card_index [j] [i]]) {
											//print (sentence [i] [card_index [j] [i]]);
											arr [0] = sentence [i] [card_index [j] [i]];
											a = n;
											print (arr [0]);
											//card_UL.text = str; 
											isfind = true;
										}
									}
								}
							}

						}
					}
					if (isfind == true) {
						int r = 0;

						for (int i = 1; i < 5; i++) {
							arr [i] = cards [(a + i) % cards.Length].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text;
						}
						/*for (int i = 1; i < 5; i++) {
				r = UnityEngine.Random.Range (0, cards.Length);
				while (a == r) {
					r = UnityEngine.Random.Range (0, cards.Length);
				}
				arr [i] = cards [r].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text;
			}*/
						for (int i = 0; i < 5; i++) {
							r = UnityEngine.Random.Range (0, 5);
							string temp = arr [i];
							arr [i] = arr [r];
							arr [r] = temp;

						}
						for (int i = 0; i < 5; i++) {
							str += "{"+ arr [i] + "}";
						}
						card_view_chinese_word_UL.text = "其中一張為正確卡牌\n請選擇:" + str; 
					} else {
						
						score -= 10;
						if(last_num_i != -1 && last_num_j != -1){
							GameObject.Find ("card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/shadow").GetComponent<UISprite> ().color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//關燈
						}
						bool is_find = false;
						for (int i = 0; i < cards.Length; i++) {
							for(int j = 0; j < twenty.Length ; j++){	
							if (cards [i].transform.Find ("Label").gameObject.GetComponent<UILabel> ().text == twenty [j]) {
									StartCoroutine(delay_detecard(cards[i]));

									print (twenty [j]);
									is_find = true;
								}
							}
							if (is_find)   break;
						}
						last_num_i = -1;
						last_num_j = -1;
						StartCoroutine (delay_grid (4 , 2.0f));

						InvokeRepeating ("send_CD", 0, 1);
						card_view_chinese_word_UL.text = "玩家目前手牌沒有答案卡!!\n---> 刪除非答案卡，進入電腦回合";
					}
				} else {
					card_view_chinese_word_UL.text = "手牌小於5張，無法使用小幫手!!";
					
				}
			
				card_view_chinese_word_UL.GetComponent<TweenScale>().Toggle();

				/*for (int i = 0; i < 3; i++) {                                                                                                                                                                                                                             
					help_hint_view_UL [i].text = "";
				}*/
			}



		}


		if (s.StartsWith ("Chinese_sentence (0)")) {
			tx.WriteToFile0 (time_UL.text,"A");

			first_sentence = true;

			hint_score -= 30;

			string str = "";
			                                                                                                                                                                                                                            
				str = d_obj.get_chinese_sentence (level, 0);
				first_sentence_UL[0].text = str;
			

		}

		if (s.StartsWith ("Chinese_sentence (1)")) {
			tx.WriteToFile0 (time_UL.text,"T");

			second_sentence = true;

			hint_score -= 30;

			string str = "";
			                                                                                                                                                                                                                             
				str = d_obj.get_chinese_sentence (level, 1);
				second_sentence_UL[1].text = str;


		}

		if (s.StartsWith ("Chinese_sentence (2)")) {
			tx.WriteToFile0 (time_UL.text,"F");

			third_sentence = true;

			hint_score -= 30;

			string str = "";
			                                                                                                                                                                                                                           
				str = d_obj.get_chinese_sentence (level, 2);
				third_sentence_UL[2].text = str;
			

		}



		if (s.StartsWith ("Chinese_word")) {


			if (last_num_i == -1 & last_num_j == -1) {
				GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
				GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "請先選擇卡牌";
			} else {

				tx.WriteToFile0 (time_UL.text, "D");
				string str = "";

				hint_score -= 10;

				str = d_obj.get_chinese_word (GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text);


				hint_UL.text = GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text+" :  " + str;


			}

		}


		if (s.StartsWith ("part_of_speech")) {

			if (last_num_i == -1 & last_num_j == -1) {
				GameObject.Find ("card_view/Label").GetComponent<TweenScale> ().Toggle ();
				GameObject.Find ("card_view/Label").GetComponent<UILabel> ().text = "請先選擇卡牌";
			} else {

				tx.WriteToFile0 (time_UL.text, "R");


				hint_score -= 10;

				string speech = "";

				speech = d_obj.get_part_of_speech (GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text);

				hint_UL.text =GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text+" :  "+ speech;


			}


		}

		/*if (s.StartsWith ("English_word") && last_num_i !=-1 && last_num_j != -1 ) {

			string english_word = "";F

			english_word = d_obj.get_english_word(GameObject.Find ("right_list/Scroll View/card_answer" + last_num_i.ToString () + "_" + last_num_j.ToString () + "/Label").GetComponent<UILabel> ().text);

			help_view_chinese_word_UL.text = english_word;

			for (int i = 0; i < 3; i++) {                                                                                                                                                                                                                             
				help_hint_view_UL[i].text = "";
			}

		}


		if (s.StartsWith ("bt_ai_correct")) {
			card_correct ();
		}


		if (s.StartsWith ("bt_ai_wrong")) {
			card_wrong ();
		}*/



	
	}


	IEnumerator  delay_detecard(GameObject obj){

		yield return new WaitForSeconds (0.5f);
			Destroy (obj);
			StartCoroutine (delay_grid (1, 0.2f));
		}

	void Update () {
		if (is_start == true) {
			
				time_f -= Time.deltaTime;
			
		}


		if (first_sentence == true) {
			first_time_f -= Time.deltaTime;
			first_time_UL.color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//出現
			chinese_first_sentence.GetComponent<BoxCollider> ().enabled = false;
		}

		if (second_sentence == true) {
			second_time_f -= Time.deltaTime;
			second_time_UL.color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//出現
			chinese_second_sentence.GetComponent<BoxCollider> ().enabled = false;
		}

		if (third_sentence == true) {
			third_time_f -= Time.deltaTime;
			third_time_UL.color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//出現
			chinese_third_sentence.GetComponent<BoxCollider> ().enabled = false;
		}
		////////////////////////////////
		time_h = (int)time_f / 3600;
		time_s = (int)time_f % 60;
		if ((int)time_f < 3600) {
			time_m = (int)time_f / 60;
		} else {
			time_m = (int)(time_f / 60)-60;
		}
		///////////////////////////////

		first_time_m = (int)first_time_f / 60;
		first_time_s = (int)first_time_f % 60;
		///////////////////////////////
		second_time_m = (int)second_time_f / 60;
		second_time_s = (int)second_time_f % 60;
		///////////////////////////////
		third_time_m = (int)third_time_f / 60;
		third_time_s = (int)third_time_f % 60;
		///////////////////////////////


		time_UL.text = time_h.ToString ("00") + ":" + time_m.ToString ("00") + ":" + time_s.ToString ("00");
		first_time_UL.text = first_time_m.ToString ("00") + ":" + first_time_s.ToString ("00");
		second_time_UL.text = second_time_m.ToString ("00") + ":" + second_time_s.ToString ("00");
		third_time_UL.text = third_time_m.ToString ("00") + ":" + third_time_s.ToString ("00");
		Score_UL.text = "玩家分數:"+score.ToString();
		AI_score_UL.text = "電腦分數:" + AI_score.ToString ();
		hint_score_UL.text = "提示分數:" + hint_score.ToString ();
		correct_UL.text = ": " + correct_count.ToString ();
		wrong_UL.text = ": " + wrong_count.ToString ();
		AI_correct_UL.text = ": " + AI_correct_count.ToString();
		AI_wrong_UL.text = ": " + AI_wrong_count.ToString();

		if ((int)time_f == 0) {
			//card_UL.GetComponent<TweenScale>().Toggle();
			//card_UL.text = "[c][ff0000ff]Game over[-][/c]";
			Game_over.transform.localPosition = new Vector3(0 , 0 , 0);//Game over
		}

		if ((int)first_time_f == 0) {
			
			first_sentence_UL [0].text = "";
			first_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
			chinese_first_sentence.GetComponent<BoxCollider> ().enabled = true;
			chinese_first_sentence.GetComponent<UISprite>().color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//物件顏色變回來
			first_time_f = 180;
			first_sentence = false;
		}

		if ((int)second_time_f == 0) {

			second_sentence_UL [1].text = "";
			second_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
			chinese_second_sentence.GetComponent<BoxCollider> ().enabled = true;
			chinese_second_sentence.GetComponent<UISprite>().color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//物件顏色變回來
			second_time_f = 180;
			second_sentence = false;
		}

		if ((int)third_time_f == 0) {

			third_sentence_UL [2].text = "";
			third_time_UL.color = new Vector4 (255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);//消失
			chinese_third_sentence.GetComponent<BoxCollider> ().enabled = true;
			chinese_third_sentence.GetComponent<UISprite>().color = new Vector4 (0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//物件顏色變回來
			third_time_f = 180;
			third_sentence = false;
		}


		


		}
	}

//[c][ff0000ff]ABC[-][/c]