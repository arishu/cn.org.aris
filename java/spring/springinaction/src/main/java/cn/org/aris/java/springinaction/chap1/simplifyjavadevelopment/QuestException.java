package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment;

public class QuestException extends Exception {
	
	private static final long serialVersionUID = -4044168325865663841L;

	public QuestException() {
		super();
	}
	
	public QuestException(String msg) {
		super(msg);
	}
	
	public QuestException(Throwable cause) {
		super(cause);
	}
	
	public QuestException(String msg, Throwable cause) {
		super(msg, cause);
	}
}
