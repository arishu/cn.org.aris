package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert;

import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.DeclareParents;

@Aspect
public class EncoreableIntroducer {
	
	@DeclareParents(value="cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance+",
			defaultImpl=DefaultEncoreable.class)
	public static Encoreable encoreable;
	
}
