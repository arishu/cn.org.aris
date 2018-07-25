package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment;

import org.junit.Test;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection.BraveKnight;

import static org.mockito.Mockito.*;

public class BraveKnightTest {
	
	@Test
	public void knightShouldEmbarkOnQuest() throws QuestException
	{
		Quest mockQuest = mock(Quest.class);
		BraveKnight knight = new BraveKnight(mockQuest);
		knight.embarkOnQuest();
		
		verify(mockQuest, times(1)).embark();
	}
	
}
