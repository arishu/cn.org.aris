package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection;

import java.io.PrintStream;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Quest;

public class SlayDragonQuest implements Quest {

	private PrintStream stream;
	
	public SlayDragonQuest(PrintStream stream) {
		this.stream = stream;
	}
	
	public void embark() {
		stream.println("Embarking on quest to slay the dragon!");
	}

}
