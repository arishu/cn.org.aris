package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem.config;

import java.util.ArrayList;
import java.util.List;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

import cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem.BlankDisc;
import cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem.CompactDisc;
import cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.soundsystem.TrackCounter;

@Configuration
@EnableAspectJAutoProxy
public class TrackCounterConfig {
	
	public CompactDisc sgtPeppers() {
		BlankDisc cd = new BlankDisc();
		cd.setTitle("Sgt. Pepper's Lonely Hearts Club Band");
		cd.setArtist("The Beatles");
		List<String> tracks = new ArrayList<String>();
		tracks.add("Sgt. Pepper's Lonely Hearts Club Band");
		tracks.add("With a Little Help from My Friends");
		tracks.add("Lucy in the Sky with Diamonds");
		tracks.add("Getting Better");
		tracks.add("Fixing a Hole");
		
		cd.setTracks(tracks);
		
		return cd;
	}
	
	@Bean
	public TrackCounter trackCounter() {
		return new TrackCounter();
	}
	
}
