package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.aspectapplying;

import java.io.PrintStream;

public class Minstrel {

	private PrintStream stream;
	
	public Minstrel(PrintStream stream) {
		this.stream = stream;
	}
	
	public void singBeforeQuest() {			// Call before quest
		stream.println("Fa la la, the knight is so brave!");
	}
	
	public void singAfterQuest() {			// Call after quest
		stream.println("The hee hee, the brave knight " + "did embark on a quest!");
	}
	
}
