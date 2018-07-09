package cn.org.aris.java.springinaction.chap2.autowiringbeans;

import org.springframework.stereotype.Component;

/**
 * 将当前类指定为Spring组件, 表明需要将这个bean添加到Spring容器中
 * @author ArisHu
 */
@Component(value="sgtPeppers")
//Component("sgtPeppers")
public class SgtPeppers implements CompactDisc {

	private String title = "Sgt. Pepper's Lonely Hearts Club Band";
	private String artist = "The Beatles";
	
	@Override
	public void play() {
		System.out.println("Playing " + title + " by " + artist);
	}
}
