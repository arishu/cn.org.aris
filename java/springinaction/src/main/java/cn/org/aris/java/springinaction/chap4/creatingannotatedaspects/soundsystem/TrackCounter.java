package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem;

import java.util.HashMap;
import java.util.Map;

import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;

@Aspect
public class TrackCounter {
	private Map<Integer, Integer> trackCounts = new HashMap<Integer, Integer>();
	
	@Pointcut("execution(* cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem.CompactDisc.playTrack(int))"
			+ "&& args(trackNumber)")
	public void countTrack(int trackNumber) {}
	
	@Before("trackPlayed(trackNumber)")
	public void controlPlayed(int trackNumber) {
		int currentCount = getPlayCount(trackNumber);
		trackCounts.put(trackNumber, currentCount + 1);
	}

	public int getPlayCount(int trackNumber) {
		return trackCounts.containsKey(trackNumber) ? trackCounts.get(trackNumber) : 0;
	}
	
}
