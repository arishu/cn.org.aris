package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.aspectapplying;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Knight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Quest;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.QuestException;

public class BraveKnight implements Knight {

	private Quest quest;
	@SuppressWarnings("unused")
	private Minstrel minstrel;
	
	public BraveKnight(Quest quest, Minstrel minstrel) {
		this.quest = quest;
		this.minstrel = minstrel;
	}
	
	@Override
	public void embarkOnQuest() throws QuestException {
		quest.embark();
	}

}
