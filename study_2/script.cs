using UnityEngine;
using System.Collections;
public class script : MonoBehaviour {
	const int grid_max = 8 , sentence_max = 30 , answer_group_max = 4 , hint_word_num = 16;
	public GameObject chessman , bg_SV , gridprefab , bt_reset , bt_change_white , bt_change_black , answer_one_shadow, bt_put_chessman, bt_next, bt_examine , bt_chinese_hint , bt_form_hint , bt_sentence_hint , bt_hints , bt_cancel , bt_quit;
	public GameObject yes , no , grammar;
	public GameObject [][]checkerboard ;
	public GameObject []bt_answer;
	public GameObject []bt_word;

	public int black_sum , white_sum , level , last_answer_num, question_num, answer_title_number, player_score , AI_score , black_eat_chessman, white_eat_chessman , correct_num , wrong_num ,hint_score, test_score;
	public int check_number_index , word_num , word_light_num;
	float time_f;
	int time_h , time_m , time_s;
	int grid_one , grid_two;
	public UISprite [][]chessman_US;
	UISprite []answer_shadow_US;
	UISprite bt_next_US , bt_yes_US , bt_no_US , bt_grammar_US;
	
	public float cd_count;
	int [][]grid_index;
	public float boxscale;
	public UIGrid Scroll_view_UG;

	public int []topic_order;

	UILabel black_sum_UL , white_sum_UL , player_score_UL , AI_score_UL , bt_next_UL;
	UILabel question_UL, judge_UL, title_UL , time_view_UL , hint_view_UL , correct_wrong_view_UL , hint_score_UL , test_score_UL , table_game_over ;
	UILabel []answer_UL;
	UILabel []hint_word_UL;
	UILabel player_score_GO , task_score_GO;
	public int order_list;
	public bool player_cd , change_chessman , answer_next , is_going_on , white_is_going_on , is_put_chessman, is_bt_examine , is_time_start , check_hint , when_black_zero , check_chessman_total_zero_B , check_chessman_total_zero_W;
	private int insert_flag;
	string behavior_total;

	word_data d_obj;
	
	txtIO tx;



	void Start () {
		random_sentence_order();
		born_checkerboard();
		

		//tx.WriteToFile0 (time_view_UL.text, "Q");
		
		setgrid();

		
		//check_over();

		middle_chessman();
		check_total_chessman();
		question();
		answer();
		//hint_word(topic_order[question_num]);
		

		title_UL.text = "第"+ (question_num + 1).ToString() +"題 :";

		bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,80f/255f);

		correct_wrong_view_UL.text = "答對:" + correct_num.ToString() + " 答錯 :" + wrong_num.ToString();

		bt_yes_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
		bt_no_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
		bt_grammar_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);

		hint_score_UL.text = "提示分數:\n" + hint_score;
	}



	void Awake(){

		tx = GameObject.Find ("script").GetComponent<txtIO> ();


		behavior_total = "";
		insert_flag = 0;
		order_list=0;
		grid_one = 0;
		grid_two = 0;

		black_sum = 0 ;
		white_sum = 0 ;
		level = 0;
		last_answer_num = -1;
		question_num = 0;
		answer_title_number = -1;
		player_score = 0;
		AI_score = 0;
		black_eat_chessman = 0;
		white_eat_chessman = 0;
		check_number_index = 0;
		word_num = -1;
		word_light_num = -1;
		correct_num = 0;
		wrong_num = 0;
		hint_score = 1000;
		test_score = 0;

		cd_count = 1.5f;
		boxscale = 0.8f;
		time_f = 3600f;
		time_h = 0;
		time_m = 0;
		time_s = 0;

		answer_shadow_US = new UISprite[answer_group_max];	

		answer_UL = new UILabel[answer_group_max];

		//hint_word_UL = new UILabel[hint_word_num];


		bt_answer = new GameObject[answer_group_max];

		bt_word = new GameObject[hint_word_num];

		d_obj = new word_data();
		
		
		topic_order = new int [sentence_max];

		player_cd = true;
		change_chessman = true;
		answer_next = false;
		is_going_on = true;
		white_is_going_on = true;
		is_put_chessman = false;
		is_bt_examine = true;
		is_time_start = true;
		check_hint = false;
		when_black_zero = false;
		check_chessman_total_zero_B = false;
		check_chessman_total_zero_W = false;

		bt_quit = GameObject.Find("Game_over/bt_quit");
		bg_SV = GameObject.Find("chess_table_panel/Scroll View box");
		bt_reset = GameObject.Find("chess_table_panel/bt_reset");
		bt_change_white = GameObject.Find("chess_table_panel/bt_change_white");
		bt_change_black = GameObject.Find("chess_table_panel/bt_change_black");
		bt_put_chessman = GameObject.Find("bg/bt_put_chessman");
		//bt_into_test = GameObject.Find("bg/bt_into_test");
		bt_next = GameObject.Find("bg/bt_next");
		bt_examine = GameObject.Find("bg/bt_examine");
		bt_chinese_hint = GameObject.Find("hint_view_panel/bg_hint/bt_chinese_hint");
		bt_form_hint = GameObject.Find("hint_view_panel/bg_hint/bt_form_hint");
		bt_sentence_hint = GameObject.Find("hint_view_panel/bg_hint/bt_sentence_hint");
		bt_hints = GameObject.Find("test_panel/bg/bt_hints");
		bt_cancel = GameObject.Find("bg_hint/bt_cancel");
		yes = GameObject.Find("judge_view/yes");
		no = GameObject.Find("judge_view/no");
		grammar = GameObject.Find("judge_view/grammar");
		//abc = GameObject.Find("hint_view_panel/bg_hint/abc");


		//bt_next_US = GameObject.Find("test_panel/bg/bt_next").GetComponent<UISprite>();
		bt_yes_US = GameObject.Find("judge_view/yes").GetComponent<UISprite>();
		bt_no_US = GameObject.Find("judge_view/no").GetComponent<UISprite>();
		bt_grammar_US = GameObject.Find("judge_view/grammar").GetComponent<UISprite>();
		
	
		black_sum_UL = GameObject.Find("chess_table_panel/black_sum").GetComponent<UILabel>();
		white_sum_UL = GameObject.Find("chess_table_panel/white_sum").GetComponent<UILabel>();
		question_UL = GameObject.Find("test_panel/bg/test_view_Label").GetComponent<UILabel>();
		judge_UL = GameObject.Find("judge_view/Label").GetComponent<UILabel>();
		title_UL = GameObject.Find("test_panel/bg/title_view_Label").GetComponent<UILabel>();
		player_score_UL = GameObject.Find("chess_table_panel/player_score").GetComponent<UILabel>();
		AI_score_UL = GameObject.Find("chess_table_panel/AI_score").GetComponent<UILabel>();
		time_view_UL = GameObject.Find("test_panel/bg/time_view_Label").GetComponent<UILabel>();
		hint_view_UL = GameObject.Find("hint_view_panel/bg_hint/hint_view/Label").GetComponent<UILabel>();
		correct_wrong_view_UL = GameObject.Find("test_panel/bg/correct_wrong_view_Label").GetComponent<UILabel>();
		hint_score_UL = GameObject.Find("test_panel/bg/hint_score").GetComponent<UILabel>();
		bt_next_UL = GameObject.Find("test_panel/bg/bt_next/Label").GetComponent<UILabel>();
		test_score_UL = GameObject.Find("test_panel/bg/test_score_Label").GetComponent<UILabel>();
		player_score_GO = GameObject.Find("Game_over/player_score").GetComponent<UILabel>();
		task_score_GO = GameObject.Find("Game_over/task_score").GetComponent<UILabel>();
		table_game_over = GameObject.Find("table_game_panel/Label").GetComponent<UILabel>();


		for(int i = 0; i<answer_group_max; i++){
			bt_answer [i] = GameObject.Find("answer_view_Scroll View/answer_Scroll View (" + i.ToString() +")/Label");// 點擊到字體
			answer_shadow_US [i] = GameObject.Find("answer_view_Scroll View/answer_Scroll View (" + i.ToString() +")/shadow").GetComponent<UISprite>();
			answer_UL [i] = GameObject.Find("answer_view_Scroll View/answer_Scroll View (" + i.ToString() +")/Label").GetComponent<UILabel>();


			UIEventListener.Get(bt_answer[i]).onClick += ButtonClick;
		}

		/*for(int i = 0; i<hint_word_num ; i++){
			bt_word[i] = GameObject.Find("hint_view_panel/bg_hint/word_view/Scroll View/word_" + i.ToString()); 
			hint_word_UL[i] = GameObject.Find("hint_view_panel/bg_hint/word_view/Scroll View/word_" + i.ToString()).GetComponent<UILabel>();
			
			UIEventListener.Get(bt_word[i]).onClick += ButtonClick;
		}*/

		Scroll_view_UG = GameObject.Find("chess_table_panel/Scroll View box").GetComponent<UIGrid>();



		checkerboard = new GameObject[grid_max][];
		chessman_US = new UISprite[grid_max][];
		grid_index = new int[grid_max][];
		for(int i = 0 ; i < grid_max ; i ++){
			checkerboard[i] = new GameObject[grid_max];
			chessman_US[i] = new UISprite[grid_max];
			grid_index[i] = new int[grid_max];
		}


		





			
		gridprefab = Resources.Load("grid")as GameObject;


		//UIEventListener.Get(abc).onClick += ButtonClick;
		UIEventListener.Get(bt_change_white).onClick += ButtonClick;
		UIEventListener.Get(bt_change_black).onClick += ButtonClick;
		//UIEventListener.Get(bt_into_test).onClick += ButtonClick;
		UIEventListener.Get(bt_reset).onClick += ButtonClick;
		UIEventListener.Get(bt_put_chessman).onClick += ButtonClick;
		UIEventListener.Get(bt_next).onClick += ButtonClick;
		UIEventListener.Get(bt_examine).onClick += ButtonClick;
		UIEventListener.Get(bt_chinese_hint).onClick += ButtonClick;
		UIEventListener.Get(bt_form_hint).onClick += ButtonClick;
		UIEventListener.Get(bt_sentence_hint).onClick += ButtonClick;
		UIEventListener.Get(bt_hints).onClick += ButtonClick;
		UIEventListener.Get(bt_cancel).onClick += ButtonClick;
		UIEventListener.Get(yes).onClick += ButtonClick;
		UIEventListener.Get(no).onClick += ButtonClick;
		UIEventListener.Get(grammar).onClick += ButtonClick;
		UIEventListener.Get(bt_quit).onClick += ButtonClick;

	}


	void insert_Logfile_total(int student_id ){
		string url = "http://ncugo.com/logfile_total.php?student_id=" + student_id.ToString() + "&Behavior_total=" + behavior_total;
		WWW www = new WWW (url);//定义一个www类型的对象

	}

	void insert_Logfile(int student_id, string behavior){
		string url;
		if(order_list == 0){
			 url = "http://ncugo.com/insert_sbe.php?student_id=" + student_id.ToString() +"&time_click=01:00:00&behavior=Q&order_list=0";
			 order_list+=1;
		}else{
			 order_list+=1;
			 url = "http://ncugo.com/insert_sbe.php?student_id=" + student_id.ToString() +"&time_click="+ time_h.ToString ("00") + ":" + time_m.ToString ("00") + ":" + time_s.ToString ("00") 
			 	+"&behavior=" + behavior+"&order_list="+order_list;
		}
		

		behavior_total += behavior;
		print(behavior+" "+url);
		WWW www = new WWW (url);//定义一个www类型的对象
		

	}





	void random_sentence_order(){
		 

		for(int i = 0 ; i < sentence_max ; i ++){
			topic_order [i] = i; 
		}

		for(int j = 0 ; j < sentence_max ; j++){
			int x = Random.Range(0,sentence_max);
			int []temp = new int [1];
			temp [0] = topic_order[j];
			topic_order[j] = topic_order[x];
			topic_order[x] = temp[0];

		}

	}

	void check_over(){
		if((question_num + 1) == 1){
			GameObject.Find("Game_over").GetComponent<TweenPosition>().Toggle();
			print("Over");
			answer_next = false;

			insert_Logfile_total(1024);

			tx.WriteToFile0 (time_view_UL.text, "玩家分數: "+ player_score.ToString() );
			tx.WriteToFile0 (time_view_UL.text, "任務分數: "+ test_score.ToString() );
			tx.WriteToFile0 (time_view_UL.text, "電腦分數: "+ AI_score.ToString());
			tx.WriteToFile0 (time_view_UL.text, "提示分數: "+ hint_score.ToString());
			string url = "http://ncugo.com/insert.php?studen_id=test&player_score="+player_score.ToString()+"&computer_score="+
				test_score.ToString()+"&remind_score="+hint_score.ToString()+"&mission_score="+AI_score.ToString();
			WWW www = new WWW (url);//定义一个www类型的对象
			print(url);
		}
	}

	void quit(){
		Application.Quit();
	}

	void question(){ //撈資料
		question_UL.text = d_obj.get_sentence(level,topic_order[question_num]);
	}

	void answer(){

		for(int i = 0 ; i< answer_group_max ; i++){
			answer_UL [i].text = d_obj.get_answer(level,topic_order[question_num])[i];
		}
	}
	
	/*void hint_word(int question_num){

		for(int i = 0 ; i<hint_word_num ; i++){
			hint_word_UL[i].text = d_obj.get_word(level,topic_order[question_num])[i];

			
		}
		
	}*/


	void sentence_hint(){
		
		hint_view_UL.text = d_obj.get_sentence_hint(level,topic_order[question_num]);
	}
	

	void sentence_grammar(){

		judge_UL.text = d_obj.get_sentence_grammar(level , topic_order[question_num]);
	}

	void sentence_grammar_game_over(){
		judge_UL.text = d_obj.get_sentence_grammar_game_over(level , topic_order[question_num]);
	}


	/*public void send_cd(){

		player_cd = false;
		cd_count -= 1;

		if(cd_count <= -1){
			CancelInvoke("send_cd");
			cd_count = 1.5f;
			player_cd = true;

		}
	}*/



	IEnumerator AI_put_chessman(float t){
		
		yield return new WaitForSeconds(t);
		
		int max = -1 , max_i = -1 , max_j = -1 , temp = 0;

		int max_W = -1 , max_i_W = -1 , max_j_W = -1 , temp_W = 0;
		
		if(change_chessman == true){
		for(int i = 0 ; i < grid_max ; i ++){
			for(int j = 0 ; j < grid_max ; j ++){
			
					if(grid_index[i][j] == -1){
					temp = 0;
					temp +=	check_rightline(i , j , 0 , true);
					temp +=	check_leftline(i , j , 0 , true);
					temp +=	check_upline(i , j , 0 , true);
					temp +=	check_downline(i , j , 0 , true);
					temp +=	check_slash_right_up_line(i , j , 0 , true);
					temp +=	check_slash_left_down_line(i , j , 0 , true);
					temp +=	check_slash_right_down_line(i , j , 0 , true);
					temp +=	check_slash_left_up_line(i , j , 0 , true);
					

					if(temp > max){
						max = temp;
						max_i = i;
						max_j = j;
						
					}
				}
			}
		}

		print("最大得分:"+max);


		
					
		white_is_going_on = true;
		white_eat_chessman = 0;
		white_eat_chessman +=	check_rightline(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_leftline(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_upline(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_downline(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_slash_right_up_line(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_slash_left_down_line(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_slash_right_down_line(max_i , max_j , 0 , true);
		white_eat_chessman +=	check_slash_left_up_line(max_i , max_j , 0 , true);
					 
		tx.WriteToFile_eat_chessman (time_view_UL.text, "電腦吃棋數: " + white_eat_chessman.ToString());

		AI_score += white_eat_chessman * 100;


		tx.WriteToFile_eat_chessman (time_view_UL.text, "電腦獲得分數: " + (white_eat_chessman*100).ToString() + "\n");
		/*if(white_eat_chessman == 0){
			white_is_going_on = false;
		}*/


		if(max_i != -1 && white_is_going_on == true ){
				
				put_chessman(max_i ,  max_j, 0);
				check_chessman(max_i , max_j , 0 , false);
				check_total_chessman();
				StartCoroutine(player_put_chessman(0.5f));
		}
	}



		if(change_chessman == false){
		for(int i = 0 ; i < grid_max ; i ++){
			for(int j = 0 ; j < grid_max ; j ++){
			
					if(grid_index[i][j] == -1){
					temp_W = 0;
					temp_W +=	check_rightline(i , j , 1 , true);
					temp_W +=	check_leftline(i , j , 1 , true);
					temp_W +=	check_upline(i , j , 1 , true);
					temp_W +=	check_downline(i , j , 1 , true);
					temp_W +=	check_slash_right_up_line(i , j , 1 , true);
					temp_W +=	check_slash_left_down_line(i , j , 1 , true);
					temp_W +=	check_slash_right_down_line(i , j , 1 , true);
					temp_W +=	check_slash_left_up_line(i , j , 1 , true);
					

					if(temp_W > max_W){
						max_W = temp_W;
						max_i_W = i;
						max_j_W = j;
						
					}
				}
			}
		}

		print("最大得分:"+max_W);
		if(max_i_W != -1 ){
				
				put_chessman(max_i_W ,  max_j_W, 1);
				
				check_chessman(max_i_W , max_j_W , 1 , false);
				check_total_chessman();
				StartCoroutine(player_put_chessman(0.5f));
				
		}
	}
				answer_next = true;
				bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);
				judge_UL.text = "下一題!!";
				judge_UL.GetComponent<TweenScale>().Toggle();
				check_over();
}






	IEnumerator player_put_chessman(float t){
			yield return new WaitForSeconds(t);

			player_cd = true;


	}



	void check_total_chessman(){
			 white_sum = 0;
			 black_sum = 0;
			for(int i = 0 ; i < grid_max ; i ++){
				for(int j  = 0 ; j < grid_max ; j ++){
					if(grid_index[i][j] == 0){
						white_sum += 1;
					}

					if(grid_index[i][j] == 1){
						black_sum += 1;
					}
				}
			}


			black_sum_UL.text = "總數:" + black_sum.ToString();
			white_sum_UL.text = "總數:" + white_sum.ToString();

			//print("白棋:" +white_sum);
			//print("黑棋:" +black_sum);
	}



	void middle_chessman(){

				put_chessman( grid_max/2 , grid_max/2 , 0);
				put_chessman( (grid_max/2)-1 , (grid_max/2)-1 , 0);
				put_chessman( grid_max/2 , (grid_max/2)-1 , 1);
				put_chessman( (grid_max/2)-1 , grid_max/2 , 1);

				
	}


//吃黑白棋(頭)	
	int check_rightline(int pos_i , int pos_j , int chessman , bool is_check){     //放左邊，往右邊檢查(放置黑棋的話)
			int sum = 0;
			int chessman_pos = -1;
			
				for(int i = pos_j+1 ; i < grid_max ; i++){
					if(grid_index[pos_i][i] == -1){  //空格子直接跳出
						break;
					}
					if(grid_index[pos_i][i] == chessman){ //紀錄到底的位置
						chessman_pos = i;
						
						break;
				}
				
			}
			if(chessman_pos != -1){
					//print(chessman_pos.ToString());
				for(int i = pos_j+1 ; i < chessman_pos ; i++){
					if(is_check == false){
					put_chessman(pos_i , i , chessman);
				}else{
					sum++;
				}
			}
		}

		return sum;
}

	int check_leftline(int pos_i , int pos_j , int chessman , bool is_check){     //放右邊，往左邊檢查(放置黑棋的話)
			int sum = 0;
			int chessman_pos = -1;
			
				for(int i = pos_j-1 ; i >= 0 ; i--){
					if(grid_index[pos_i][i] == -1){  //空格子直接跳出
						break;
					}

					if(grid_index[pos_i][i] == chessman){ //紀錄到底的位置
						chessman_pos = i;
						
						break;
				}
			}
				
			if(chessman_pos != -1){	
				for(int i = pos_j-1 ; i > chessman_pos ; i--){
					if(is_check == false){
					put_chessman(pos_i , i , chessman);
					}else{
						sum++;

					}
					
				}
		}
		return sum;
}
				


	int check_upline(int pos_i , int pos_j , int chessman,bool is_check){     //放下面，往上面檢查(放置黑棋的話)
			int sum =0;
			int chessman_pos = -1;
			
				for(int i = pos_i+1 ; i < grid_max ; i++){
					if(grid_index[i][pos_j] == -1){  //空格子直接跳出
						break;
					}

					if(grid_index[i][pos_j] == chessman){ //紀錄到底的位置
						chessman_pos = i;
						
						break;
				}
			}
				
			if(chessman_pos != -1){		
				for(int i = pos_i+1 ; i < chessman_pos ; i++){
					if(is_check == false){
						put_chessman(i , pos_j, chessman);
					}else{
						sum++;
				}
			}
		}
		return sum;
}


	int check_downline(int pos_i , int pos_j , int chessman , bool is_check){     //放上面，往下面檢查(放置黑棋的話)
			int sum = 0;
			int chessman_pos = -1;
			
				for(int i = pos_i-1 ; i >= 0 ; i--){
					if(grid_index[i][pos_j] == -1){  //空格子直接跳出
						break;
					}
					if(grid_index[i][pos_j] == chessman){ //紀錄到底的位置
						chessman_pos = i;
						
						break;
				}
			}
				
			if(chessman_pos != -1){		
				for(int i = pos_i-1 ; i > chessman_pos ; i--){
					if(is_check == false){
						put_chessman(i , pos_j, chessman);
					}else{
						sum++;
					}
					
				}
		}
		return sum;
}




	int check_slash_right_up_line(int pos_i , int pos_j , int chessman , bool is_check){  //放左下，往右上檢查(放置黑棋的話)
		int sum = 0;
		int chessman_pos = -1;
		
			for(int i = 1 ; i < grid_max ; i++){
				

				if(pos_i-i < 0 || pos_j+i > grid_max-1){ //判斷棋盤上面、右邊範圍
					break;
				}

				if(grid_index[pos_i-i][pos_j+i] == -1){
					break;
				}

				


				if(grid_index[pos_i-i][pos_j+i] == chessman){
					chessman_pos = i;
					break;
				}

			}	



			if(chessman_pos > 1){
				for(int i = 1 ; i < chessman_pos ; i++){
					if(is_check == false){
						put_chessman(pos_i-i , pos_j+i , chessman);
					}else{
						sum ++;
					}
					
			}
			
	}
	
	return sum;
}


	int check_slash_left_down_line(int pos_i , int pos_j , int chessman , bool is_check){ //放右上，往左下檢查(放置黑棋的話)
		int sum = 0;
		int chessman_pos = -1;
			for(int i = 1 ; i < grid_max ; i++){
				

				if(pos_i+i > grid_max-1 || pos_j-i < 0){ //判斷棋盤下面、左邊範圍
					break;
				}

				if(grid_index[pos_i+i][pos_j-i] == -1){
					break;
				}

				


				if(grid_index[pos_i+i][pos_j-i] == chessman){
					chessman_pos = i;
					break;
				}

			}	



			if(chessman_pos > 1){
				for(int i = 1 ; i < chessman_pos ; i++){
					if(is_check == false){
						put_chessman(pos_i+i , pos_j-i , chessman);
					}else{
						sum++;
					}
			}
			
	}
		
		return sum;
}


	int check_slash_right_down_line(int pos_i , int pos_j , int chessman , bool is_check){ //放左上，往右下檢查(放置黑棋的話)
		int sum = 0;
		int chessman_pos = -1;
			for(int i = 1 ; i < grid_max ; i++){
				

				if(pos_i+i > grid_max-1 || pos_j+i > grid_max-1){ //判斷棋盤下面、右邊範圍
					break;
				}

				if(grid_index[pos_i+i][pos_j+i] == -1){
					break;
				}

				


				if(grid_index[pos_i+i][pos_j+i] == chessman){
					chessman_pos = i;
					break;
				}

			}	



			if(chessman_pos > 1){
				for(int i = 1 ; i < chessman_pos ; i++){
					if(is_check == false){
						put_chessman(pos_i+i , pos_j+i , chessman);
					}else{
						sum ++;
					}
			}

	}
		
		return sum;
}



	int check_slash_left_up_line(int pos_i , int pos_j , int chessman , bool is_check){ //放右下，往左上檢查(放置黑棋的話)
		int sum = 0;
		int chessman_pos = -1;
			for(int i = 1 ; i < grid_max ; i++){
				

				if(pos_i-i < 0 || pos_j-i < 0 ){ //判斷棋盤下面、右邊範圍
					break;
				}

				if(grid_index[pos_i-i][pos_j-i] == -1){
					break;
				}

				


				if(grid_index[pos_i-i][pos_j-i] == chessman ){
					chessman_pos = i;
					break;
				}

			}	



			if(chessman_pos > 1 ){
				for(int i = 1 ; i < chessman_pos ; i++){
					if(is_check == false){
						put_chessman(pos_i-i , pos_j-i , chessman);
					}else{
						sum ++;
					}
			}
			
	}

	 return sum;
}

//吃黑白棋(尾)	

				/*if(grid_index[pos_i+i][pos_j] == 0){ //檢查下面(放置黑棋的話)
					put_chessman(pos_i+i , pos_j , 1);
				}
				
			for(int j = 0 ; j < grid_max ;j--){
				if(grid_index[pos_i][pos_j-j] == 0 ){ //檢查左邊(放置黑棋的話)
					put_chessman(pos_i , pos_j-j , 1);
				}else if(grid_index[pos_i-j][pos_j] == 0 ){ //檢查上面(放置黑棋的話)
					put_chessman(pos_i-j , pos_j , 1);
				}


			}*/	
		

			/*if(grid_index[pos_i][pos_j-1] == 1){ //檢查左邊(放置白棋的話)
				put_chessman(pos_i , pos_j-1 , 0);
			}*/
	


	void put_chessman(int i ,  int j , int k){
		if( k == 0 ){
				chessman_US[i][j].color = new Vector4(255f/255f,255f/255f,255f/255f,255f/255f);
				chessman_US[i][j].spriteName = "chess-w";
				grid_index[i][j] = 0;
			}
			if( k == 1 ){
				chessman_US[i][j].color = new Vector4(255f/255f,255f/255f,255f/255f,255f/255f);
				chessman_US[i][j].spriteName = "chess-B";
				grid_index[i][j] = 1;
			}
			
		
	}


	





	void check_chessman(int i , int j  , int k  , bool is_check){
			check_rightline(i , j , k , is_check);
			check_leftline(i , j , k , is_check);
			check_upline(i , j , k , is_check);
			check_downline(i , j , k , is_check);
			check_slash_right_up_line(i , j , k , is_check);
			check_slash_left_down_line(i , j , k , is_check);
			check_slash_right_down_line(i , j , k , is_check);
			check_slash_left_up_line(i , j , k , is_check);

	}

	public void born_checkerboard(){
		int sum = 0;

		for(int i = 0 ; i < grid_max ; i++){
			for(int j = 0 ; j < grid_max ; j++){
					checkerboard[i][j] =  (GameObject)Instantiate(gridprefab,new Vector3(0,0,0),Quaternion.identity);
					checkerboard[i][j].name = "grid_"+sum.ToString();

					chessman_US[i][j] = checkerboard[i][j].transform.Find("chessman").GetComponent<UISprite>();//找checkerboard底下的chessman(uisprite)

					UIEventListener.Get(checkerboard[i][j]).onClick += ButtonClick;
					checkerboard[i][j].transform.parent = bg_SV.transform;
					
					checkerboard[i][j].transform.localScale= new Vector3(boxscale,boxscale,1f);

					grid_index[i][j] = -1;



					sum += 1;

			}
		}

	}

	void setgrid(){
		Scroll_view_UG.maxPerLine = grid_max;
		Scroll_view_UG.Reposition();
	}


	void reset(){

		for(int i = 0 ; i < grid_max ; i++){
			for(int j = 0 ; j <grid_max ; j++){
			chessman_US[i][j].color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			grid_index[i][j] = -1;
			}
		}
			
			middle_chessman();

			check_total_chessman();
		
			player_score = 0;
			AI_score = 0;

	}




	int check_black_grid(){
		int sum = 0 ;
		for(int i = 0 ; i < grid_max ; i++){
			for(int j = 0 ; j < grid_max ; j++){
				if(grid_index[i][j] == 1){
					sum += 1;
				}
		
			}
		}

		return sum;
	}

	int check_white_grid(){
		int sum = 0 ;
		for(int i = 0 ; i < grid_max ; i++){
			for(int j = 0 ; j < grid_max ; j++){
				if(grid_index[i][j] == 0){
					sum += 1;
				}
		
			}
		}

		return sum;
	}



	/*void limit_position(int sum){
		int temp;

		temp = 0;
		temp +=	check_rightline(i , j , 0 , true);
		temp +=	check_leftline(i , j , 0 , true);
		temp +=	check_upline(i , j , 0 , true);
		temp +=	check_downline(i , j , 0 , true);
		temp +=	check_slash_right_up_line(i , j , 0 , true);
		temp +=	check_slash_left_down_line(i , j , 0 , true);
		temp +=	check_slash_right_down_line(i , j , 0 , true);
		temp +=	check_slash_left_up_line(i , j , 0 , true);
	}*/

	

	public void ButtonClick(GameObject obj){
			string s = obj.name;



			if(s.StartsWith("bt_quit")){
				quit();
				print("quit");
			}










			if(check_chessman_total_zero_B == false && check_chessman_total_zero_W == false){
			if( is_put_chessman == true){
			if(player_cd == true ){
			if(s.StartsWith("grid_")){

				int temp = 0 , sum = 0 , check_grid_sum_W = 0 ;
				
				int prev_num = int.Parse(s.Substring(5).ToString());
				
				if(grid_index[prev_num/grid_max][prev_num%grid_max] == -1 ){
					
							grid_one = prev_num/grid_max;
							grid_two = prev_num%grid_max;

							tx.WriteToFile_grid (time_view_UL.text, "grid_" + grid_one.ToString() + "_" + grid_two.ToString());

					if(change_chessman == true){

								is_going_on = true;
								temp = 0;
								temp +=	check_rightline(prev_num/grid_max , prev_num%grid_max , 1 , true);
								//print("::"+(check_rightline(prev_num/grid_max , prev_num%grid_max , 1 , true).ToString()));
								//print((prev_num/grid_max).ToString()+ " " + (prev_num%grid_max).ToString());
								temp +=	check_leftline(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_upline(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_downline(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_slash_right_up_line(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_slash_left_down_line(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_slash_right_down_line(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								temp +=	check_slash_left_up_line(prev_num/grid_max , prev_num%grid_max  , 1 , true);
								sum += temp;
								
								black_eat_chessman = sum;

								tx.WriteToFile_eat_chessman(time_view_UL.text, "玩家吃棋數: " + black_eat_chessman.ToString());

								if(check_number_index == 0){
									player_score += black_eat_chessman * 100;
									tx.WriteToFile_eat_chessman(time_view_UL.text, "玩家獲得分數: " + (black_eat_chessman*100).ToString());
								}else if(check_number_index == 1){
									player_score += black_eat_chessman * 50;
									tx.WriteToFile_eat_chessman(time_view_UL.text, "玩家獲得分數: " + (black_eat_chessman*50).ToString());
								}else if(check_number_index == 2){
									player_score += black_eat_chessman * 10;
									tx.WriteToFile_eat_chessman(time_view_UL.text, "玩家獲得分數: " + (black_eat_chessman*10).ToString());
								}



								print("sum :" + sum.ToString());
							if(black_eat_chessman == 0){
								is_going_on = false;
								judge_UL.text = "未能得分 ，再選擇一次!!";
								judge_UL.GetComponent<TweenScale>().Toggle();
							}

										

					
									if(is_going_on == true){
										

										


										put_chessman(prev_num/grid_max ,  prev_num%grid_max , 1);





										check_chessman(prev_num/grid_max , prev_num%grid_max , 1 , false );

										check_total_chessman();

										player_cd = false;


										is_put_chessman = false;


										check_grid_sum_W += check_white_grid();
					
									if(check_grid_sum_W < 1){
										
										//tx.WriteToFile0 (time_view_UL.text, "O");
										insert_Logfile(1024, "O");

										check_chessman_total_zero_W = true;
										table_game_over.text = "Win";
										table_game_over.color = new Vector4(255f/255f,0f/255f,0f/255f,255f/255f);

										player_score += 1000;

										answer_next = true;
										bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);
										judge_UL.text = "恭喜獲得1000分，請點擊下一題!!";
										judge_UL.GetComponent<TweenScale>().Toggle();
										check_over();
									}



										if(check_chessman_total_zero_W == false){
											
											StartCoroutine(AI_put_chessman(2.0f));
										}
										

									}

									
						
					}

					if(change_chessman == false){
						put_chessman(prev_num/grid_max , prev_num%grid_max , 0);

						StartCoroutine(AI_put_chessman(2.0f));

						check_chessman(prev_num/grid_max , prev_num%grid_max , 0 , false );


						check_total_chessman();

						player_cd = false;
					}








				}
				


			
				
				//print(prev_num.ToString());
				print(s);
				

			}
		}
	}
}
		
		
	


		if(s.StartsWith("bt_reset")){
					reset();
					print(s);
		}



		if(s.StartsWith("bt_change_white")){
				change_chessman = false;

				print("change_white");

		}

		if(s.StartsWith("bt_change_black")){
				change_chessman = true;

				print("change_black");

		}

		/*if(s.StartsWith("bt_into_test")){
			GameObject.Find("test_panel").transform.localPosition = new Vector3(0,0,0);// 畫面切換到測驗

		}*/

		if(s.StartsWith("bt_put_chessman")){
			//GameObject.Find("test_panel").transform.localPosition = new Vector3(2000,0,0);// 畫面切換到黑白棋

			for(int i = 0; i < answer_group_max ; i ++){
					answer_shadow_US [i].color = new Vector4(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);// answer全關燈
				}

		}

	if(answer_next == true){
		if(s.StartsWith("bt_next")){
			
			int check_grid_sum_B = 0 ;

			//tx.WriteToFile0 (time_view_UL.text, "X");
			insert_Logfile(1024, "X");
			last_answer_num = -1;
			for(int i = 0; i < answer_group_max ; i ++){
					answer_shadow_US [i].color = new Vector4(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);// answer全關燈
				}

			judge_UL.text = ""; 
			question_num += 1;
			answer_title_number = -1;
			check_number_index = 0;
			
			title_UL.text = "第"+ (question_num + 1).ToString() +"題 :"; 
			question();
			answer();
			is_bt_examine = true;

			bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,80f/255f);
			answer_next = false;
			

			
			correct_wrong_view_UL.text = "答對:" + correct_num.ToString() + " 答錯 :" + wrong_num.ToString();


			bt_yes_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			bt_no_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			bt_grammar_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			

			hint_view_UL.text = "";
			
				if(check_hint == true){
					GameObject.Find("bg_hint").GetComponent<TweenPosition>().Toggle();
					check_hint = false;
				}

				check_grid_sum_B += check_black_grid();
				
										

				if(check_grid_sum_B < 1){
					
					//tx.WriteToFile0 (time_view_UL.text, "P");
					insert_Logfile(1024, "P");

					check_chessman_total_zero_B = true;
					table_game_over.text = "Game over";
					table_game_over.color = new Vector4(255f/255f,0f/255f,0f/255f,255f/255f);
					check_over();
				} 




			}
		}




		

		if(check_hint == false){
			if(s.StartsWith("bt_hints")){
				
				//tx.WriteToFile0 (time_view_UL.text, "H");
				insert_Logfile(1024, "H");
				GameObject.Find("bg_hint").GetComponent<TweenPosition>().Toggle();
				sentence_hint();
				check_hint = true;
				hint_score -= 20;
				hint_score_UL.text = "提示分數:\n"  + hint_score;
			}
	}

		/*if(s.StartsWith("bt_rule")){

			GameObject.Find("bg_rule").GetComponent<TweenPosition>().Toggle();
		}*/

		if(s.StartsWith("bt_cancel")){
			check_hint = false;
		}


		if(is_bt_examine == true){
			if(s.StartsWith("bt_examine")){
					//tx.WriteToFile0 (time_view_UL.text, "S");
					insert_Logfile(1024, "S");

					if(answer_title_number == -1){
					
					judge_UL.text = "請選擇答案!!";
					judge_UL.GetComponent<TweenScale>().Toggle();
				}
				
				if(answer_title_number != -1){
					if( answer_title_number == d_obj.get_answer_num(level,topic_order[question_num])-1){ //判斷答案正確

						//tx.WriteToFile0 (time_view_UL.text, "Y");
						insert_Logfile(1024, "Y");
						if(check_number_index == 0){
									
									judge_UL.text = "答題正確 ，是否觀看文法說明? \n (如果觀看文法說明，則玩家分數+100分)";
									judge_UL.GetComponent<TweenScale>().Toggle();

									test_score += 10;

							}else if(check_number_index == 1){
									
									judge_UL.text = "答題正確 ，是否觀看文法說明? \n (如果觀看文法說明，則玩家分數+50分)";
									judge_UL.GetComponent<TweenScale>().Toggle();

									test_score += 5;
							}


						is_bt_examine = false;
						

						correct_num += 1;
						correct_wrong_view_UL.text = "答對:" + correct_num.ToString() + " 答錯 :" + wrong_num.ToString();

						bt_yes_US.color = new Vector4(255f/255f,255f/255f,255f/255f,255f/255f);
						bt_no_US.color = new Vector4(255f/255f,255f/255f,255f/255f,255f/255f);

						


					}else{//判斷答案錯誤

						if(check_number_index ==0){
							//tx.WriteToFile0 (time_view_UL.text, "N");
							insert_Logfile(1024, "N");
						}
							
							judge_UL.text = "答題錯誤 ，請再作答一次!!";
							judge_UL.GetComponent<TweenScale>().Toggle();
							check_number_index += 1;
							

							wrong_num += 1;
							correct_wrong_view_UL.text = "答對:" + correct_num.ToString() + " 答錯 :" + wrong_num.ToString();
					


						
					}

				
				
						if( check_number_index == 2){
							//tx.WriteToFile0 (time_view_UL.text, "M");
							insert_Logfile(1024, "M");
							is_bt_examine = false;
							judge_UL.text = "答錯兩次 ，請點擊文法說明!!";
							judge_UL.GetComponent<TweenScale>().Toggle();
							bt_grammar_US.color = new Vector4(255f/255f,255f/255f,255f/255f,255f/255f);
						}

				}
		}

		}

		/*if(s.StartsWith("word_")){

			int n = int.Parse(s.Substring(5));
			word_num = n;

			if(word_light_num != -1){
				for(int i = 0 ; i<hint_word_num ; i++){
					hint_word_UL[i].color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);//全部變黑色
				}
			}
			if(word_light_num == word_num){
				word_light_num = -1;
				word_num = -1;
			}else{
				hint_word_UL[word_num].color = new Vector4(255f/255f,0f/255f,0f/255f,255f/255f);//變紅色
				word_light_num = n;
			}	

			




			print("第"+ (word_num+1).ToString() +"個單字");
		}*/

		if(s.StartsWith("bt_sentence_hint")){
			
			sentence_hint();
		}



		if(s.StartsWith("yes")){
			//tx.WriteToFile0 (time_view_UL.text, "A");
			insert_Logfile(1024, "A");

			bt_yes_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			bt_no_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);

			if(check_chessman_total_zero_B == false && check_chessman_total_zero_W == false){
				
				sentence_grammar();
				is_put_chessman = true;

			}else{
				sentence_grammar_game_over();
				is_put_chessman = false;

				answer_next = true;
				bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);
				
				check_over();

			}


			
			
					
			if(check_number_index == 0){
									
					player_score += 100;

			}else if(check_number_index == 1){
									
					player_score += 50;
			}
					
			

		}

		if(s.StartsWith("no")){
			//tx.WriteToFile0 (time_view_UL.text, "D");
			insert_Logfile(1024, "D");
			

			if(check_chessman_total_zero_B == false && check_chessman_total_zero_W == false){
				judge_UL.text = "請下棋!";
				judge_UL.GetComponent<TweenScale>().Toggle();

				is_put_chessman = true;
			}else{
				judge_UL.text = "下一題!";
				judge_UL.GetComponent<TweenScale>().Toggle();

				is_put_chessman = false;
				answer_next = true;
				bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);
				check_over();
			}

			bt_yes_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);
			bt_no_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);

		}

		if(s.StartsWith("grammar")){
			//tx.WriteToFile0 (time_view_UL.text, "G");
			insert_Logfile(1024, "G");
			
			if(check_chessman_total_zero_B == false && check_chessman_total_zero_W == false){
				sentence_grammar();
				is_put_chessman = true;
			}else{
				sentence_grammar_game_over();

				is_put_chessman = false;
				answer_next = true;
				bt_next_UL.color = new Vector4(0f/255f,0f/255f,0f/255f,255f/255f);
				check_over();
			}

			bt_grammar_US.color = new Vector4(255f/255f,255f/255f,255f/255f,0f/255f);

		}

		/*if(word_num != -1){
		if(s.StartsWith("bt_chinese_hint")){
				
				string str = "";
				
				str = d_obj.get_chinese_word(hint_word_UL[word_num].text);

				hint_view_UL.text = hint_word_UL[word_num].text + ": " + str;

		}
	}
		if(word_num != -1){
		if(s.StartsWith("bt_form_hint")){
			string str = "";
				
			str = d_obj.get_form_word(hint_word_UL[word_num].text);

			hint_view_UL.text = hint_word_UL[word_num].text + ": " + str;
		}
	}*/
		
		if(s.StartsWith("Label")){ //選擇答案(4選1)
			
			int n = int.Parse(obj.transform.parent.gameObject.name[20].ToString());
			//print(n.ToString());
			answer_title_number = n;


			if( n == 0){
				//tx.WriteToFile0 (time_view_UL.text, "I");
				insert_Logfile(1024, "I");
			}

			if( n == 1){
				//tx.WriteToFile0 (time_view_UL.text, "J");
				insert_Logfile(1024, "J");
			}

			if( n == 2){
				//tx.WriteToFile0 (time_view_UL.text, "K");
				insert_Logfile(1024, "K");
			}

			if( n == 3){
				//tx.WriteToFile0 (time_view_UL.text, "L");
				insert_Logfile(1024, "L");
			}


			if(last_answer_num != -1){ // answer全關燈
				for(int i = 0; i < answer_group_max ; i ++){
					answer_shadow_US [i].color = new Vector4(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);// answer全關燈
				}
			}

			if(last_answer_num == n){
				last_answer_num = -1;
				answer_title_number = -1;
			}else{
				
				obj.transform.parent.gameObject.transform.Find("shadow").GetComponent<UISprite>().color = new Vector4(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);//開燈
				last_answer_num = n;
			}


			



		}




}

	
	void Update () {
	
		if(is_time_start == true){
			time_f -= Time.deltaTime;
		}

		time_h = (int)time_f / 3600;
		time_m = (int)time_f / 60;
		time_s = (int)time_f % 60;
		
		time_view_UL.text = time_h.ToString ("00") + ":" + time_m.ToString ("00") + ":" + time_s.ToString ("00");


		player_score_GO.text = "玩家分數 : " + player_score.ToString();
		task_score_GO.text = "任務分數 : " + test_score.ToString();
		player_score_UL.text = "玩家分數 : " + player_score.ToString();
		test_score_UL.text = "任務分數 : " + test_score.ToString();
		AI_score_UL.text = "電腦分數 : " + AI_score.ToString();

	}
}
