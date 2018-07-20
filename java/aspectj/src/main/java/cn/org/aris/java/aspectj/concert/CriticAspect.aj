package cn.org.aris.java.aspectj.concert;

public aspect CriticAspect {
	
	public CriticAspect() {}
	
	pointcut performance() : execution(* perform(..));
	
	after() returning() : performance() {
		System.out.println(criticismEngine.getCriticism());
	}
	
	private CriticismEngine criticismEngine;

	public void setCriticismEngine(CriticismEngine criticismEngine) {
		this.criticismEngine = criticismEngine;
	}
}
