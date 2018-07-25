package cn.org.aris.java.spring.spittr.data;

import cn.org.aris.java.spring.spittr.Spitter;

public interface SpitterRepository {

	Spitter save(Spitter spitter);

	Spitter findByUsername(String username);

}
