package cn.org.aris.java.spittr.data;

import cn.org.aris.java.spittr.Spitter;

public interface SpitterRepository {

	Spitter save(Spitter spitter);
	
	Spitter findByUserName(String username);
}
