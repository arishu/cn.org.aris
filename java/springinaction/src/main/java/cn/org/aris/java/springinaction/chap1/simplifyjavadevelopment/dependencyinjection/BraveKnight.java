package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Knight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Quest;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.QuestException;

public class BraveKnight implements Knight {

	private Quest quest;
	
	public BraveKnight(Quest quest) {
		this.quest = quest;
	}
	
	public void embarkOnQuest() throws QuestException {
		quest.embark();
	}

}
