using UnityEngine;
using System.Collections;

public class word_data  {

	

	public string get_sentence(int level_num , int sentence_num){
		string str = "";
		if(level_num == 0){
			switch(sentence_num){
				case 0:
					str = "Collaborative learning stimulates engagements in valuable learning activities___individual learning allows students to undertake learning tasks autonomously. " ;
					break;
				case 1:
					str = "The arrangement of navigation tools ____________ with the needs of each individual. " ;
					break;
				case 2:
					str = "_____________, no one instructional method is suitable for all. " ;
					break;
				case 3:
					str = "The preferences of ________illustrated in Figure 2. " ;
					break;
				case 4:
					str = "Table 3 ______________in each cluster. " ;
					break;
				case 5:
					str = "The results _______________that females performed better than males. " ;
					break;
				case 6:
					str = "On the other hand, students in Cluster 3 had ______________ " ;
					break;
				case 7:
					str = "On the other hand, students in Cluster 4 spent _____________the practical tasks among the three clusters. " ;
					break;
				case 8:
					str = "___________, Field Dependent students significant showed different learning patterns among the three clusters. " ;
					break;
				case 9:
					str = "Game-based Learning___________ refers to the methodologies and design features of computer games, used to support learning. " ;
					break;
				case 10:
					str = "Holists preferred to listen to the music __________________. " ;
					break;
				case 11:
					str = "The learning patterns _______________the learning performance of females and males. " ;
					break;
				case 12:
					str = "___________________________a difficult task. " ;
					break;
				case 13:
					str = "English grammar is concerned with a set of rules__________ words and groups of words may be linked together to create meaningful sentences. " ;
					break;
				case 14:
					str = "Traditional teacher-based instructional approaches cannot ______________ learning English grammar " ;
					break;
				case 15:
					str = "Students need to follow grammar rules ____________their academic papers can be clearly understood by readers " ;
					break;
				case 16:
					str = "Learning English grammar is not only stale and unexciting to them, __________lets them feel very anxious (Chen, 2018). " ;
					break;
				case 17:
					str = "_____________attempted to address this issue with various digital tools. " ;
					break;
				case 18:
					str = "_______________, e-assessment is also a potential way that can be applied to support English grammar learning. " ;
					break;
				case 19:
					str = "E-assessment can be applied to support student learning in three aspects, ________listening skills, vocabulary acquisition and reading comprehension. " ;
					break;
				case 20:
					str = "E-assessment offers immediate feedback________ can enhance students’ understandings of main concepts " ;
					break;
				case 21:
					str = "E-assessment can narrow the gap ________________. " ;
					break;
				case 22:
					str = "Instant visual feedback can ____________________. " ;
					break;
				case 23:
					str = "________________reach optimal performance. " ;
					break;
				case 24:
					str = "Some researchers developed computer-based scaffolding ___________. " ;
					break;
				case 25:
					str = "Students with computer-based scaffolding performed better ____________ " ;
					break;
				case 26:
					str = "The SEEL has three features, ____________" ;
					break;
				case 27:
					str = "_____________these three main features into the SEEL is useful to a variety of learners. " ;
					break;
				case 28:
					str = "Previous research indicated that _______________from e-assessment differently. " ;
					break;
				case 29:
					str = "Differences between Holists and Serialists are ____________are concerned with affective states. " ;
					break;

				default:

					break;

			}
		}
		return str;
	}


	public string []get_answer(int level_num , int sentence_num){
		string []str = new string[4];
		if(level_num == 0){
			switch(sentence_num){
				case 0:
					str = new string[] { 
					"(A)  ;"	,
					"(B)  ,"	,
					"(C)  because" ,
					"(D)  thus"	};
					break;
				case 1:
					str = new string[] { 
					"(A)  can be automatical adapted match"	,
					"(B)  can be automatically adapted to match" ,
					"(C)  can automatically adapt to match" ,
					"(D)  can be automatically adapted matching"	};
					break;
				case 2:
					str = new string[] { 
					"(A)  Because of individual differences exist between learners"	,
					"(B)  Due to individual differences exist among learners"	,
					"(C)  Because individual differences exist among learners" ,
					"(D)  In consequence, individual differences exist among learners"	};
					break;
				case 3:
					str = new string[] { 
					"(A)  each cognitive style group was"	,
					"(B)  each cognitive style groups is"	,
					"(C)  each cognitive style group are" ,
					"(D)  each cognitive style group is"	};
					break;
				case 4:
					str = new string[] { 
					"(A)  show the students’ post-test score"	,
					"(B)  show the students’ post-test scores"	,
					"(C)  shows the students’ post-test scores" ,
					"(D)  showed the students’ post-test scores"	};
					break;
				case 5:
					str = new string[] { 
					"(A)  shown in Figure 4 revealed"	,
					"(B)  shown in Figure 4 reveal"	,
					"(C)  showing in Figure 4 revealed" ,
					"(D)  shown in Figure 4 revealing"	};
					break;
				case 6:
					str = new string[] { 
					"(A)  the most low level of preliminary understandings."	,
					"(B)  the lowest level of preliminary understandings."	,
					"(C)  lowest level of preliminary understandings." ,
					"(D)  most low level of preliminary understandings."	};
					break;
				case 7:
					str = new string[] { 
					"(A)  the less time completing"	,
					"(B)  the least time to complete"	,
					"(C)  the least time completing" ,
					"(D)  the less time to complete"	};
					break;
				case 8:
					str = new string[] { 
					"(A)  However"	,
					"(B)  But"	,
					"(C)  Although" ,
					"(D)  Because"	};
					break;
				case 9:
					str = new string[] { 
					"(A)  , that"	,
					"(B)  that"	,
					"(C)  , which" ,
					"(D)  where"	};
					break;
				case 10:
					str = new string[] { 
					"(A)  , Serialists avoided to use hints"	,
					"(B)  ; Serialists avoided to use hints"	,
					"(C)  ; Serialists avoided using hints" ,
					"(D)  , Serialists avoided using hints"	};
					break;
				case 11:
					str = new string[] { 
					"(A)  did not significantly influence"	,
					"(B)  did not significantly effect"	,
					"(C)  did not significant affect" ,
					"(D)  did not significant influence"	};
					break;
				case 12:
					str = new string[] { 
					"(A)  Writing English academic papers without any English grammatical errors is"	,
					"(B)  Write English academic papers without any English grammatical errors is"	,
					"(C)  Writing English academic papers without any English grammatical errors are" ,
					"(D)  To write English academic papers without any English grammatical errors are"	};
					break;
				case 13:
					str = new string[] { 
					"(A)  by which"	,
					"(B)  by that"	,
					"(C)  by where" ,
					"(D)  in that"	};
					break;
				case 14:
					str = new string[] { 
					"(A)  make students to feel interesting in"	,
					"(B)  make students feel interested in"	,
					"(C)  make students to feel interested in" ,
					"(D)  make students feel interesting in"	};
					break;
				case 15:
					str = new string[] { 
					"(A)  so as to"	,
					"(B)  in order to"	,
					"(C)  so" ,
					"(D)  so that"	};
					break;
				case 16:
					str = new string[] { 
					"(A)  as well as"	,
					"(B)  but also"	,
					"(C)  or" ,
					"(D)  nor"	};
					break;
				case 17:
					str = new string[] { 
					"(A)  A number of researchers"	,
					"(B)  A number of research"	,
					"(C)  An amount of studies" ,
					"(D)  An amount of researchers"	};
					break;
				case 18:
					str = new string[] { 
					"(A)  In addition to use the aforementioned approaches"	,
					"(B)  In addition to using the aforementioned approaches"	,
					"(C)  In addition using the aforementioned approaches" ,
					"(D)  In addition use the aforementioned approaches"	};
					break;
				case 19:
					str = new string[] { 
					"(A)  e.g.,"	,
					"(B)  i.e.,"	,
					"(C)  including" ,
					"(D)  include"	};
					break;
				case 20:
					str = new string[] { 
					"(A)  of which"	,
					"(B)  , which"	,
					"(C)  , that" ,
					"(D)  where"	};
					break;
				case 21:
					str = new string[] { 
					"(A)  between actual and desired performance"	,
					"(B)  among actual and desired performance"	,
					"(C)  of actual and desired performance" ,
					"(D)  on actual and desired performance"	};
					break;
				case 22:
					str = new string[] { 
					"(A)  provide students for new learning opportunities"	,
					"(B)  provide new learning opportunities with students"	,
					"(C)  provide students with new learning opportunities" ,
					"(D)  provide new learning opportunities to students"	};
					break;
				case 23:
					str = new string[] { 
					"(A)  Provide feedback only may not be able to make all students"	,
					"(B)  Provide feedback only may not be able to facilitate all students"	,
					"(C)  Providing feedback only may not be able to facilitate all students" ,
					"(D)  Providing feedback only may not be able to make all students"	};
					break;
				case 24:
					str = new string[] { 
					"(A)  by incorporating scaffolding into digital learning tools"	,
					"(B)  by incorporate scaffolding into digital learning tools"	,
					"(C)  by incorporating scaffolding at digital learning tools" ,
					"(D)  by incorporate scaffolding at digital learning tools"	};
					break;
				case 25:
					str = new string[] { 
					"(A)  than those with paper-based scaffolding."	,
					"(B)  than paper-based scaffolding."	,
					"(C)  than that with paper-based scaffolding." ,
					"(D)  than these with paper-based scaffolding."	};
					break;
				case 26:
					str = new string[] { 
					"(A)  including (a) learning by assessing, (b) scaffolding hints, and (c) instant feedback,etc."	,
					"(B)  e.g., (a) learning by assessing, (b) scaffolding hints, and (c) instant feedback, etc."	,
					"(C)  i.e., (a) learning by assessing, (b) scaffolding hints, and (c) instant feedback, etc." ,
					"(D)  i.e., (a) learning by assessing, (b) scaffolding hints, and (c) instant feedback."	};
					break;
				case 27:
					str = new string[] { 
					"(A)  It is still unknown whether incorporate"	,
					"(B)  They are still unknown whether incorporating"	,
					"(C)  It is still unknown whether incorporating" ,
					"(D)  They are still unknown whether incorporation"	};
					break;
				case 28:
					str = new string[] { 
					"(A)  different cognitive styles groups benefited;"	,
					"(B)  different cognitive style groups benefited"	,
					"(C)  different cognitive style groups beneficial" ,
					"(D)  different cognitive styles groups beneficial"	};
					break;
				case 29:
					str = new string[] { 
					"(A)  either associated with cognitive processing, nor"	,
					"(B)  not only associated with cognitive processing, but also"	,
					"(C)  no only associated with cognitive processing, but also" ,
					"(D)  neither associated with cognitive processing, or"	};
					break;
				default:

					break;
				

			}
		}
		
		return str;
	}




	public string get_sentence_hint(int level_num , int sentence_num){
		string str = "";
		if(level_num == 0){
			switch(sentence_num){
				case 0:
					str = "合作學習激發了參與有價值的學習活動,個人學習使學生能夠自主地完成學習任務 ";
					break;
				case 1:
					str = "引導工具的排列可以自動地調整以適應每個人的需求 ";
					break;
				case 2:
					str = "由於學習者之間存在個體差異，因此沒有一種教學方法適合所有人";
					break;
				case 3:
					str = "每個認知風格組的偏好如圖2所示";
					break;
				case 4:
					str = "表3顯示了每個組別中學生的後測分數 ";
					break;
				case 5:
					str = "圖4中顯示的結果表明，女性的表現要好於男性 ";
					break;
				case 6:
					str = "另一方面，第3組學生的初步理解程度最低 ";
					break;
				case 7:
					str = "另一方面，在四個組別中，第四組的學生花費最少的時間來完成實際任務 ";
					break;
				case 8:
					str = "然而，場依賴的學生在這三個群體中顯著表現出不同的學習模式 ";
					break;
				case 9:
					str = "遊戲式學習是指電腦遊戲的方法和設計特色，其用於幫助學習 ";
					break;
				case 10:
					str = "整體型偏好於聽音樂； 序列型避免使用提示 ";
					break;
				case 11:
					str = "學習方式對男女的學習成績沒有顯著地影響";
					break;
				case 12:
					str = "在撰寫英語學術論文時沒有任何的英語文法錯誤是一件困難的任務 ";
					break;
				case 13:
					str = "英語文法關於一組規則，透過這些規則，單詞和單詞組可以連接在一起以創建有意義的句子 ";
					break;
				case 14:
					str = "傳統的教師教學方法不能使學生在學習英語文法時感到有趣 ";
					break;
				case 15:
					str = "學生需要遵守文法規則，以便讀者可以清楚地理解其學術論文 ";
					break;
				case 16:
					str = "學習英語文法不僅使他們感到過時和無趣，而且也讓他們感到非常焦慮 ";
					break;
				case 17:
					str = "一些學者嘗試使用不同的數位工具處理這個問題";
					break;
				case 18:
					str = "除了使用上述方法外，電子評量也是一種應用於支持英語文法學習的潛在方式 ";
					break;
				case 19:
					str = "電子評量可以應用於三個方面來支持學生的學習，即聽力技能，詞彙獲得和閱讀理解 ";
					break;
				case 20:
					str = "電子評量提供即時回饋，可以增強學生對主要概念的理解 ";
					break;
				case 21:
					str = "電子評量可以縮小實際表現與期望表現之間的差距 ";
					break;
				case 22:
					str = "即時的視覺回饋可以為學生提供新的學習機會 ";
					break;
				case 23:
					str = "僅提供回饋可能無法使所有學生都達到最佳的表現 ";
					break;
				case 24:
					str = "一些學者透過將鷹架納入到數位學習工具中，以開發電腦的鷹架";
					break;
				case 25:
					str = "用電腦鷹架的學生比那些用書面鷹架的學生表現更好 ";
					break;
				case 26:
					str = "SEEL具有三個功能，即（a）透過評量學習，（b）鷹架輔助提示和（c）即時回饋 ";
					break;
				case 27:
					str = "將這三個主要功能結合到SEEL中是否對各種的學習者有用仍然是未知的 ";
					break;
				case 28:
					str = "先前的研究表明，不同的認知風格群體從電子評量中受益的方式有所不同 ";
					break;
				case 29:
					str = "整體型和序列型之間的差異不僅與認知過程有關聯，而且也與情感狀態有關聯 ";
					break;
				
				default:

					break;
				

			}
		}
		
		return str;
	}



	public string get_sentence_grammar(int level_num , int sentence_num){
		string str = "";
		if(level_num == 0){
			switch(sentence_num){
				
				case 0:
					str = "分號可以連接句子，逗號不可以 \n(觀看後請下棋) ";
					break;
				case 1:
					str = "副詞automatically用來修飾動詞adapted \n(觀看後請下棋) ";
					break;
				case 2:
					str = "三者之間用among，because才可以連接子句 \n(觀看後請下棋)";
					break;
				case 3:
					str = "preferences是主詞，所以用複數動詞are \n(觀看後請下棋)";
					break;
				case 4:
					str = "第三人稱單數動詞 + s \n(觀看後請下棋) ";
					break;
				case 5:
					str = "用過去分詞shown表示被動 \n(觀看後請下棋) ";
					break;
				case 6:
					str = "單音節的形容詞 + est，且前面需 + the \n(觀看後請下棋) ";
					break;
				case 7:
					str = "spend後面需 + Ving \n(觀看後請下棋) ";
					break;
				case 8:
					str = "However表示然而，放於句首 \n(觀看後請下棋) ";
					break;
				case 9:
					str = "非限定關係代名詞在which之前加逗號 \n(觀看後請下棋) ";
					break;
				case 10:
					str = "avoid後面 + Ving \n(觀看後請下棋) ";
					break;
				case 11:
					str = "副詞修飾動詞 \n(觀看後請下棋)";
					break;
				case 12:
					str = "分詞構句作主詞時用單數動詞 \n(觀看後請下棋) ";
					break;
				case 13:
					str = "介係詞可放在關係代名詞which之前，但不可放在that之前 \n(觀看後請下棋) ";
					break;
				case 14:
					str = "使役動詞後加原形動詞 \n(觀看後請下棋) ";
					break;
				case 15:
					str = "so that = 以致於，後面接子句 \n(觀看後請下棋) ";
					break;
				case 16:
					str = "not only...but also... = 不僅...而且... \n(觀看後請下棋) ";
					break;
				case 17:
					str = "research不可數，study和researcher可數 \n(觀看後請下棋)";
					break;
				case 18:
					str = "介係詞後接名詞，所以動詞要變成Ving \n(觀看後請下棋)";
					break;
				case 19:
					str = "i.e. = 也就是，所以是「也就是三方面」 \n(觀看後請下棋) ";
					break;
				case 20:
					str = "非限定關係代名詞，which之前加逗號 \n(觀看後請下棋) ";
					break;
				case 21:
					str = "兩者之間用between \n(觀看後請下棋) ";
					break;
				case 22:
					str = "provide 人 with 物 \n(觀看後請下棋) ";
					break;
				case 23:
					str = "分詞構句才可以作主詞 \n(觀看後請下棋) ";
					break;
				case 24:
					str = "介係詞後，動詞要加Ving，變成動名詞 \n(觀看後請下棋)";
					break;
				case 25:
					str = "用those代替students \n(觀看後請下棋) ";
					break;
				case 26:
					str = "i.e. = 也就是，也就是三個功能 \n(觀看後請下棋) ";
					break;
				case 27:
					str = "虛主詞用it代替 \n(觀看後請下棋) ";
					break;
				case 28:
					str = "名詞做形容詞不加s \n(觀看後請下棋) ";
					break;
				case 29:
					str = "not only...but also... = 不僅...而且... \n(觀看後請下棋) ";
					break;
				
				default:

					break;




				

			}
		}
		
		return str;
	}



		public string get_sentence_grammar_game_over(int level_num , int sentence_num){
		string str = "";
		if(level_num == 0){
			switch(sentence_num){
				
				case 0:
					str = "分號可以連接句子，逗號不可以 \n(觀看後請點擊下一題) ";
					break;
				case 1:
					str = "副詞automatically用來修飾動詞adapted \n(觀看後請點擊下一題) ";
					break;
				case 2:
					str = "三者之間用among，because才可以連接子句 \n(觀看後請點擊下一題)";
					break;
				case 3:
					str = "preferences是主詞，所以用複數動詞are \n(觀看後請點擊下一題)";
					break;
				case 4:
					str = "第三人稱單數動詞 + s \n(觀看後請點擊下一題) ";
					break;
				case 5:
					str = "用過去分詞shown表示被動 \n(觀看後請點擊下一題) ";
					break;
				case 6:
					str = "單音節的形容詞 + est，且前面需 + the \n(觀看後請點擊下一題) ";
					break;
				case 7:
					str = "spend後面需 + Ving \n(觀看後請點擊下一題) ";
					break;
				case 8:
					str = "However表示然而，放於句首 \n(觀看後請點擊下一題) ";
					break;
				case 9:
					str = "非限定關係代名詞在which之前加逗號 \n(觀看後請點擊下一題) ";
					break;
				case 10:
					str = "avoid後面 + Ving \n(觀看後請點擊下一題) ";
					break;
				case 11:
					str = "副詞修飾動詞 \n(觀看後請點擊下一題)";
					break;
				case 12:
					str = "分詞構句作主詞時用單數動詞 \n(觀看後請點擊下一題) ";
					break;
				case 13:
					str = "介係詞可放在關係代名詞which之前，但不可放在that之前 \n(觀看後請點擊下一題) ";
					break;
				case 14:
					str = "使役動詞後加原形動詞 \n(觀看後請點擊下一題) ";
					break;
				case 15:
					str = "so that = 以致於，後面接子句 \n(觀看後請點擊下一題) ";
					break;
				case 16:
					str = "not only...but also... = 不僅...而且... \n(觀看後請點擊下一題) ";
					break;
				case 17:
					str = "research不可數，study和researcher可數 \n(觀看後請點擊下一題)";
					break;
				case 18:
					str = "介係詞後接名詞，所以動詞要變成Ving \n(觀看後請點擊下一題)";
					break;
				case 19:
					str = "i.e. = 也就是，所以是「也就是三方面」 \n(觀看後請點擊下一題) ";
					break;
				case 20:
					str = "非限定關係代名詞，which之前加逗號 \n(觀看後請點擊下一題) ";
					break;
				case 21:
					str = "兩者之間用between \n(觀看後請點擊下一題) ";
					break;
				case 22:
					str = "provide 人 with 物 \n(觀看後請點擊下一題) ";
					break;
				case 23:
					str = "分詞構句才可以作主詞 \n(觀看後請點擊下一題) ";
					break;
				case 24:
					str = "介係詞後，動詞要加Ving，變成動名詞 \n(觀看後請點擊下一題)";
					break;
				case 25:
					str = "用those代替students \n(觀看後請點擊下一題) ";
					break;
				case 26:
					str = "i.e. = 也就是，也就是三個功能 \n(觀看後請點擊下一題) ";
					break;
				case 27:
					str = "虛主詞用it代替 \n(觀看後請點擊下一題) ";
					break;
				case 28:
					str = "名詞做形容詞不加s \n(觀看後請點擊下一題) ";
					break;
				case 29:
					str = "not only...but also... = 不僅...而且... \n(觀看後請點擊下一題) ";
					break;
				
				default:

					break;




				

			}
		}
		
		return str;
	}

	/*public string []get_word(int level_num , int sentence_num){
		string []str = new string[30];
		if(level_num == 0){
			switch(sentence_num){
				case 0:
					str = new string[] {"Traditional" , "take" , "a" , "single" , "mode" , "only" , "while" , "our" , "proposed" , "approach" , "integrates" , "two" , "modes" , "together" , "peer" , "response"};
					break;
				case 1:
					str = new string[] { 
					"Cognitive styles play an essential role in educational settings because they affect information processing habits of learners and capture their preferred mode of problem solving "	,
					"Digital games include a variety of entertainment elements that make students have much fun but they are forced to process various types of information simultaneously "	,
					"Not all of elementary learners have enough capacities and resources to overcome the problems of cognitive overload and disorientation because individual differences exist among learners "	};
					break;
				case 2:
					str = new string[] { 
					"Empirical results from previous research in the area of educational technologies indicated that collaborative mobile learning has positive effects on learning motivation and learning performance "	,
					"This study investigated the effects of game-based learning and found that students with digital games received demonstrate much better achievement than those with traditional instruction "	,
					"We used a digital puzzle game to teach English and our finding indicated that it could make students enjoy studying for this course very much "	};
					break;
				case 3:
					str = new string[] { 
					"Programming skills have become a core competence that all students need to possess so they can develop their career in the field of information technology "	,
					"Online tests were widely applied to enhance students learning but they failed to engage students in deep thinking and reflections on extremely complex logical relationships "	,
					"A relative paucity of research investigates why the two-tier test approach is effective because previous research mainly focused on examining the effectiveness of this approach "	};
					break;
				case 4:
					str = new string[] { 
					"Game-based learning is very popular in current educational settings because it includes a variety of game elements that provide learners with a lot of entertainment "	,
					"Previous research found that background music could affect learners’ information processing patterns and such patterns might have great effects on their learning performance and perceptions "	,
					"This research aims to provide the complete understandings of the effects of background music in the context of digital learning from a cognitive style aspect "	};
					break;
				case 5:
					str = new string[] { 
					"There is a need to consider individual differences , among which cognitive styles particularly affect student learning in educational settings because they are concerned with individuals’ the preferences of information processing and organization "	,
					"The results from the post-test scores and questionnaire demonstrated that students in the mobile device scenario not only showed more positive reactions but also performed better than those in the desktop computer scenario "	,
					"Female and male learners performed differently in the desktop computer scenario and the mobile device scenario ; however, they spent a similar amount of time for completing the tasks in these two scenarios "	};
					break;
				default:

					break;
				

			}
		}
		
		return str;
	}*/




	public int get_answer_num(int level_num , int sentence_num){
		int num = 0;
		if(level_num == 0){
			switch(sentence_num){
					case 0:   
							num = 1;
					break;
					case 1:
							num = 2;
					break;
					case 2:
							num = 3;
					break;
					case 3:
							num = 3;
					break;
					case 4:
							num = 3;
					break;
					case 5:
							num = 1;
					break;
					case 6:
							num = 2;
					break;
					case 7:
							num = 3;
					break;
					case 8:
							num = 1;
					break;
					case 9:
							num = 3;
					break;
					case 10:
							num = 3;
					break;
					case 11:
							num = 1;
					break;
					case 12:
							num = 1;
					break;
					case 13:
							num = 1;
					break;
					case 14:
							num = 2;
					break;
					case 15:
							num = 4;
					break;
					case 16:
							num = 2;
					break;
					case 17:
							num = 1;
					break;
					case 18:
							num = 2;
					break;
					case 19:
							num = 2;
					break;
					case 20:
							num = 2;
					break;
					case 21:
							num = 1;
					break;
					case 22:
							num = 3;
					break;
					case 23:
							num = 4;
					break;
					case 24:
							num = 1;
					break;
					case 25:
							num = 1;
					break;
					case 26:
							num = 4;
					break;
					case 27:
							num = 3;
					break;
					case 28:
							num = 2;
					break;
					case 29:
							num = 2;
					break;

				default: 
					
					break;
 		
			}

		}
		return num;
	}


	public string get_chinese_word(string s){
		string new_str = "";
		new_str = s.Substring(0);
		string chinese_word = "";
		switch(new_str){

		case "Traditional" :  chinese_word = "傳統的" ; break;
		case "take" :  chinese_word = "採取" ; break;
		case "a" :  chinese_word = "一個" ; break;
		case "single" :  chinese_word = "單一的" ; break;
		case "mode" :  chinese_word = "模式" ; break;
		case "only" :  chinese_word = "只有" ; break;
		case "while" :  chinese_word = "而" ; break;
		case "our" :  chinese_word = "我們的" ; break;
		case "proposed" :  chinese_word = "提議" ; break;
		case "approach" :  chinese_word = "方法" ; break;
		case "integrates" :  chinese_word = "整合" ; break;
		case "two" :  chinese_word = "兩個" ; break;
		case "modes" :  chinese_word = "模式" ; break;
		case "together" :  chinese_word = "一起" ; break;
		case "peer" :  chinese_word = "同儕的" ; break;
		case "response" :  chinese_word = "回應" ; break;


		}

		return chinese_word;
	}

	public string get_form_word(string s){
		string new_str = "";
		new_str = s.Substring(0);
		string part_of_speech = "";
		switch(new_str){

		case "Traditional" :  part_of_speech = "2" ; break;
		case "peer" :  part_of_speech = "2" ; break;
		case "response" :  part_of_speech = "0" ; break;
		
		case "take" :  part_of_speech = "1" ; break;
		case "a" :  part_of_speech = "冠詞" ; break;
		case "single" :  part_of_speech = "2" ; break;
		case "mode" :  part_of_speech = "0" ; break;
		case "only" :  part_of_speech = "3" ; break;
		case "while" :  part_of_speech = "5" ; break;
		case "our" :  part_of_speech = "2" ; break;
		case "proposed" :  part_of_speech = "1" ; break;
		case "approach" :  part_of_speech = "0" ; break;
		case "integrates" :  part_of_speech = "1" ; break;
		case "two" :  part_of_speech = "冠詞" ; break;
		case "modes" :  part_of_speech = "0" ; break;
		case "together" :  part_of_speech = "3" ; break;


		}


		if(part_of_speech == "0") return "名詞";
		if(part_of_speech == "1") return "動詞";
		if(part_of_speech == "2") return "形容詞";
		if(part_of_speech == "3") return "副詞";
		if(part_of_speech == "4") return "介系詞";
		if(part_of_speech == "5") return "連接詞";
		if(part_of_speech == "6") return "代名詞";

		return part_of_speech;
	}

	}
