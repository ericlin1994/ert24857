using UnityEngine;
using System.Collections;

public class data : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	public string get_sentence_word(int level_num , int sentence_num){
		string str ="";
		if (level_num == 0) {
			switch(sentence_num){
			case 0:
				str = "Traditional peer response approaches take a single mode only while our proposed approach integrates two modes together " ;
				break;
			case 1:
				str = "Whether females and males equally favor to use the integrative peer response is examined in this study " ;
				break;
			case 2:
				str = "We investigate how and why gender differences affect learning motivation in the context of collaborative game-based learning " ;
				break;
				/*case 0:
				str = "Peer response is useful to " ;
				break;
			case 1:
				str = "improve student writing but students may " ;
				break;
			case 2:
				str = "not enjoy writing essays very much " ;
				break;*/
			}
		}
		return str;
	}
	public string get_invalid_word(int level_num){
		string str = "";
		if (level_num == 0) {
			str =  "should understand lecture manage researcher match satisfaction dependent independent remembered data come proponents go join well article teacher Mature irrespective enhance class perform quality " ;
			// "should understand lecture manage researcher match tendency dependent independent remembered like come proponents go join well article teacher Mature conducted did class perform contributes " ;

		}
		return str;
	}
	public int get_key_word(int level_num){
		int NN=-1;
		if (level_num == 0) {
			NN = 8;
		}
		if (level_num == 1) {
			NN = 8;
		}
		if (level_num == 2) {
			NN = 8;
		}
		return NN;
	}

	public string get_chinese_sentence(int level_num , int sentence_num){
		string str = "";
		if (level_num == 0) {
			switch(sentence_num){
			case 0:
				str = "第一句:傳統的同儕回應方法只採用單一模式,而我們提出的方法將兩種模式結合在一起" ;
				break;
			case 1:
				str = "第二句:本研究考察了女性和男性是否同樣喜歡使用整合式同儕回應" ;
				break;
			case 2:
				str = "第三句:在合作式遊戲學習的背景下我們調查性別差異如何以及為什麼影響學習動機" ;
				break;
			}
		}
		return str;
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



		case "Whether" :  chinese_word = "無論是" ; break;
		case "females" :  chinese_word = "女性" ; break;
		case "males" :  chinese_word = "男性" ; break;
		case "equally" :  chinese_word = "同樣" ; break;
		case "favor" :  chinese_word = "青睞" ; break;
		case "to" :  chinese_word = "於" ; break;
		case "use" :  chinese_word = "使用" ; break;
		case "the" :  chinese_word = "那個" ; break;
		case "integrative" :  chinese_word = "整合的" ; break;
		case "examined" :  chinese_word = "檢驗" ; break;
		case "in" :  chinese_word = "在" ; break;
		case "this" :  chinese_word = "這個" ; break;
		case "study" :  chinese_word = "研究" ; break;





		case "We" :  chinese_word = "我們" ; break;
		case "investigate" :  chinese_word = "調查" ; break;
		case "how" :  chinese_word = "如何" ; break;
		case "why" :  chinese_word = "為甚麼" ; break;
		case "gender" :  chinese_word = "性別" ; break;
		case "differences" :  chinese_word = "差異" ; break;
		case "affect" :  chinese_word = "影響" ; break;
		case "learning" :  chinese_word = "學習" ; break;
		case "motivation" :  chinese_word = "動機" ; break;
		case "context" :  chinese_word = "背景" ; break;
			//case "so" :  chinese_word = "所以" ; break;
		case "of" :  chinese_word = "於" ; break;
		case "collaborative" :  chinese_word = "共同的" ; break;
		case "game-based" :  chinese_word = "遊戲式" ; break;









		case "The" :  chinese_word = "那個" ; break;
		case "usefulness" :  chinese_word = "有效性" ; break;
		case "and" :  chinese_word = "和" ; break;
		case "engagement" :  chinese_word = "參與度" ; break;
		//case "of" :  chinese_word = "於" ; break;
		case "peer" :  chinese_word = "同儕" ; break;
		case "response" :  chinese_word = "回應" ; break;
		case "approaches" :  chinese_word = "方法" ; break;
		case "were" :  chinese_word = "是" ; break;
		case "strongly" :  chinese_word = "強烈地" ; break;
		case "associated" :  chinese_word = "相關的" ; break;
		case "with" :  chinese_word = "以" ; break;
		case "ability" :  chinese_word = "能力" ; break;
		case "levels" :  chinese_word = "水平" ; break;
		case "that" :  chinese_word = "即" ; break;
		case "students" :  chinese_word = "學生" ; break;
		case "possessed" :  chinese_word = "擁有" ; break;

	
			
		case "dual" :  chinese_word = "雙" ; break;
		//case "mode" :  chinese_word = "模式" ; break;
		case "was" :  chinese_word = "是" ; break;
		case "beneficial" :  chinese_word = "有益的" ; break;
		case "for" :  chinese_word = "對於" ; break;
		case "high-ability" :  chinese_word = "高能力" ; break;
		//case "devices" :  chinese_word = "裝置" ; break;
		//case "the" :  chinese_word = "那個" ; break;
		//case "single" :  chinese_word = "單一的" ; break;
		//case "while" :  chinese_word = "而" ; break;
		case "advantageous" :  chinese_word = "有利的" ; break;
		//case "were" :  chinese_word = "是" ; break;
		//case "to" :  chinese_word = "對" ; break;
		case "low-ability" :  chinese_word = "低能力" ; break;
		//case "this" :  chinese_word = "逗號" ; break;
		//case "study" :  chinese_word = "誰的" ; break;





		case "Peer" :  chinese_word = "同儕" ; break;
		case "is" :  chinese_word = "是" ; break;
		case "useful" :  chinese_word = "有用的" ; break;
		case "improve" :  chinese_word = "提高" ; break;
		case "student" :  chinese_word = "學生" ; break;
		case "writing" :  chinese_word = "寫作" ; break;
		case "but" :  chinese_word = "但是" ; break;
		case "may" :  chinese_word = "可能" ; break;
		case "not" :  chinese_word = "不" ; break;
		case "enjoy" :  chinese_word = "享受" ; break;
		//case "so" :  chinese_word = "所以" ; break;
		case "essays" :  chinese_word = "文章" ; break;
		case "very" :  chinese_word = "非常" ; break;
		case "much" :  chinese_word = "許多" ; break;
		//case "learning" :  chinese_word = "他們" ; break;
		/*case "experience" :  chinese_word = "經歷" ; break;
		case "more" :  chinese_word = "更多的" ; break;
		case "lot" :  chinese_word = "批量" ; break;
		case "difficulties" :  chinese_word = "困難" ; break;
		case "in" :  chinese_word = "在" ; break;
		case "performing" :  chinese_word = "執行" ; break;
		case "speaking" :  chinese_word = "口語" ; break;
		case "listening" :  chinese_word = "聽力" ; break;
		case "tasks" :  chinese_word = "任務" ; break;*/





			/////////////////////////   雜牌24張    ////////////////////////////////////
			//case "Our" :  chinese_word = "我們的" ; break;
		case "should" :  chinese_word = "應該" ; break;
		case "understand" :  chinese_word = "了解" ; break;
		case "lecture" :  chinese_word = "演講" ; break;
		case "manage" :  chinese_word = "管理" ; break;
		case "researcher" :  chinese_word = "研究員" ; break;
		case "match" :  chinese_word = "配" ; break;
		case "satisfaction" :  chinese_word = "滿意" ; break;
		case "dependent" :  chinese_word = "依賴的" ; break;
		case "independent" :  chinese_word = "獨立的" ; break;
		case "remembered":  chinese_word = "記得"; break;
		case "data":  chinese_word = "資料"; break;
		case "come" :  chinese_word = "過來" ; break;
		case "article" :  chinese_word = "文章" ; break;  
		case "go" :  chinese_word = "去" ; break;
		case "join" :  chinese_word = "參與" ; break;
		case "proponents" :  chinese_word = "支持者" ; break;
		case "teacher" :  chinese_word = "老師" ; break;
		case "Mature" :  chinese_word = "成熟" ; break;
		case "irrespective" :  chinese_word = "不論" ; break;
		case "enhance" :  chinese_word = "提高" ; break;
		case "class" :  chinese_word = "課堂" ; break;
		case "perform" :  chinese_word = "演出" ; break;
		case "quality" :  chinese_word = "品質" ; break;
		case "well" :  chinese_word = "好" ; break;           
		case "pattern" :  chinese_word = "模式" ; break;
		/*case "motivation" :  chinese_word = "動機" ; break;
		case "aspect" :  chinese_word = "方面" ; break;
		case "background" :  chinese_word = "背景" ; break;
		case "music" :  chinese_word = "音樂" ; break;
		case "entertainment" :  chinese_word = "娛樂" ; break;
		case "strategies" :  chinese_word = "策略" ; break;
		case "mechanisms" :  chinese_word = "機制" ; break;*/



		}

		return chinese_word;	
	}

	public string get_part_of_speech(string s){
		string new_str = "";
		new_str = s.Substring(0);
		string part_of_speech = "";
		switch(new_str){
		case "Traditional" :  part_of_speech = "2" ; break;
		case "peer" :  part_of_speech = "2" ; break;
		case "response" :  part_of_speech = "0" ; break;
		case "approaches" :  part_of_speech = "1" ; break;
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



		case "Whether" :  part_of_speech = "5" ; break;
		case "females" :  part_of_speech = "0" ; break;
		case "and" :  part_of_speech = "5" ; break;
		case "males" :  part_of_speech = "0" ; break;
		case "equally" :  part_of_speech = "3" ; break;
		case "favor" :  part_of_speech = "1" ; break;
		case "to" :  part_of_speech = "4" ; break;
		case "use" :  part_of_speech = "1" ; break;
		case "the" :  part_of_speech = "冠詞" ; break;
		case "integrative" :  part_of_speech = "2" ; break;
		case "is" :  part_of_speech = "1" ; break;
			//case "were" :  part_of_speech = "是" ; break;
		case "examined" :  part_of_speech = "1" ; break;
		case "in" :  part_of_speech = "4" ; break;
		case "this" :  part_of_speech = "6" ; break;
		case "study" :  part_of_speech = "0" ; break;





		case "We" :  part_of_speech = "6" ; break;
		case "investigate" :  part_of_speech = "1" ; break;
		case "how" :  part_of_speech = "3" ; break;
		case "why" :  part_of_speech = "3" ; break;
		case "gender" :  part_of_speech = "0" ; break;
		case "differences" :  part_of_speech = "0" ; break;
		case "affect" :  part_of_speech = "1" ; break;
		case "learning" :  part_of_speech = "0" ; break;
		case "motivation" :  part_of_speech = "0" ; break;
		case "context" :  part_of_speech = "0" ; break;
			//case "so" :  part_of_speech = "所以" ; break;
		case "of" :  part_of_speech = "4" ; break;
		case "collaborative" :  part_of_speech = "2" ; break;
		case "game-based" :  part_of_speech = "2" ; break;
		//case "learning" :  part_of_speech = "0" ; break;



		case "The" :  part_of_speech = "冠詞" ; break;
		case "usefulness" :  part_of_speech = "0" ; break;
		//case "and" :  part_of_speech = "5" ; break;
		case "engagement" :  part_of_speech = "0" ; break;
		//case "of" :  part_of_speech = "4" ; break;
		case "were" :  part_of_speech = "1" ; break;
		case "strongly" :  part_of_speech = "3" ; break;
		case "associated" :  part_of_speech = "2" ; break;
		case "with" :  part_of_speech = "5" ; break;
		case "ability" :  part_of_speech = "0" ; break;
		case "levels" :  part_of_speech = "0" ; break;
		case "that" :  part_of_speech = "6" ; break;
		case "students" :  part_of_speech = "0" ; break;
		case "possessed" :  part_of_speech = "1" ; break;



		case "dual" :  part_of_speech = "2" ; break;
		//case "mode" :  part_of_speech = "0" ; break;
		case "was" :  part_of_speech = "1" ; break;
		case "beneficial" :  part_of_speech = "2" ; break;
		case "for" :  part_of_speech = "4" ; break;
		case "high-ability" :  part_of_speech = "0" ; break;
			//case "devices" :  part_of_speech = "裝置" ; break;
		//case "the" :  part_of_speech = "冠詞" ; break;
		//case "single" :  part_of_speech = "2" ; break;
		//case "while" :  part_of_speech = "5" ; break;
		case "advantageous" :  part_of_speech = "2" ; break;
			//case "were" :  part_of_speech = "是" ; break;
		//case "to" :  part_of_speech = "4" ; break;
		case "low-ability" :  part_of_speech = "0" ; break;
			//case "this" :  part_of_speech = "逗號" ; break;
			//case "study" :  part_of_speech = "誰的" ; break;





		case "Peer" :  part_of_speech = "2" ; break;
		//case "is" :  part_of_speech = "1" ; break;
		case "useful" :  part_of_speech = "2" ; break;
		case "improve" :  part_of_speech = "1" ; break;
		case "student" :  part_of_speech = "0" ; break;
		case "writing" :  part_of_speech = "0" ; break;
		case "but" :  part_of_speech = "5" ; break;
		case "may" :  part_of_speech = "1" ; break;
		case "not" :  part_of_speech = "3" ; break;
		case "enjoy" :  part_of_speech = "1" ; break;
			//case "so" :  part_of_speech = "所以" ; break;
		case "essays" :  part_of_speech = "0" ; break;
		case "very" :  part_of_speech = "3" ; break;
		case "much" :  part_of_speech = "冠詞" ; break;





			/////雜牌24張/////
		case "should" :   part_of_speech = "1" ; break;
		case "understand" :   part_of_speech = "1" ; break;
		case "lecture" :   part_of_speech = "0" ; break;
		case "manage" :   part_of_speech = "1" ; break;
		case "researcher" :   part_of_speech = "0" ; break;
		case "match" :   part_of_speech = "1" ; break;
		case "satisfaction" :   part_of_speech = "0" ; break;
		case "dependent" :   part_of_speech = "2" ; break;
		case "independent" :   part_of_speech = "2" ; break;
		case "remembered":   part_of_speech = "1"; break;
		case "data":   part_of_speech = "0"; break;
		case "come" :   part_of_speech = "1" ; break;
		case "article" :   part_of_speech = "0" ; break;
		case "go" :   part_of_speech = "1" ; break;
		case "join" :   part_of_speech = "1" ; break;
		case "proponents" :   part_of_speech = "0" ; break;
		case "teacher" :   part_of_speech = "0" ; break;
		case "Mature" :   part_of_speech = "2" ; break;
		case "irrespective" :   part_of_speech = "2" ; break;
		case "enhance" :   part_of_speech = "1" ; break;
		case "class" :   part_of_speech = "0" ; break;
		case "perform" :   part_of_speech = "1" ; break;
		case "quality" :   part_of_speech = "0" ; break;
		case "well" :   part_of_speech = "3" ; break;
		case "pattern" :  part_of_speech = "0" ; break;
		/*case "motivation" :  part_of_speech = "0" ; break;
		case "aspect" :  part_of_speech = "0" ; break;
		case "background" :  part_of_speech = "0" ; break;
		case "music" :  part_of_speech = "0" ; break;
		case "entertainment" :  part_of_speech = "0" ; break;
		case "strategies" :  part_of_speech = "0" ; break;
		case "mechanisms" :  part_of_speech = "0" ; break;*/


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

	/*public string get_english_word(string s){
		string new_str = "";
		new_str = s.Substring(0);
		string english_word = "";
		switch(new_str){
		case "aaa0" :  english_word = "dfg" ; break;
		case "aaa1" :  english_word = "sdf" ; break;
		case "aaa2" :  english_word = "sda" ; break;
		case "aaa3" :  english_word = "cxz" ; break;
		case "aaa4" :  english_word = "vcx" ; break;
		case "aaa5" :  english_word = "bvc" ; break;
		case "aaa6" :  english_word = "nbv" ; break;
		case "aaa7" :  english_word = "mnb" ; break;
		case "aaa8" :  english_word = "kjh" ; break;
		case "aaa9" :  english_word = "uyt" ; break;
		case "aaa10":  english_word = "ytr" ; break;

		case "bbb0" :  english_word = "abc" ; break;
		case "bbb1" :  english_word = "dfg" ; break;
		case "bbb2" :  english_word = "hij" ; break;
		case "bbb3" :  english_word = "klm" ; break;
		case "bbb4" :  english_word = "qwe" ; break;
		case "bbb5" :  english_word = "asd" ; break;
		case "bbb6" :  english_word = "zxc" ; break;
		case "bbb7" :  english_word = "edc" ; break;
		case "bbb8" :  english_word = "rfv" ; break;
		case "bbb9" :  english_word = "rfv" ; break;
		case "bbb10":  english_word = "tgb"; break;

		case "ccc0" :  english_word = "qaz" ; break;
		case "ccc1" :  english_word = "ujm" ; break;
		case "ccc2" :  english_word = "yhn" ; break;
		case "ccc3" :  english_word = "ikm" ; break;
		case "ccc4" :  english_word = "tyu" ; break;
		case "ccc5" :  english_word = "rty" ; break;
		case "ccc6" :  english_word = "uio" ; break;
		case "ccc7" :  english_word = "hjk" ; break;
		case "ccc8" :  english_word = "fgh" ; break;
		case "ccc9" :  english_word = "vbn" ; break;
		case "ccc10":  english_word = "bnm" ; break;



		}

		return english_word;	
	}*/

	// Update is called once per frame
	void Update () {

	}
}
