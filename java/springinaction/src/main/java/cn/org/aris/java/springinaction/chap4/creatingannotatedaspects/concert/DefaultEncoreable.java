package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert;

public class DefaultEncoreable implements Encoreable {

	@Override
	public void performEncore() {
		System.out.println("Default Encoreable");
	}

}
