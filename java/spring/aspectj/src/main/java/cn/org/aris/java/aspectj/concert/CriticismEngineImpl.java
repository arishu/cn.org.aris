package cn.org.aris.java.aspectj.concert;

public class CriticismEngineImpl implements CriticismEngine {
	
	public CriticismEngineImpl() {}
	
	// injected
	private String[] criticismPool;
	
	public void setCriticismPool(String[] criticismPool) {
		this.criticismPool = criticismPool;
	}

	@Override
	public String getCriticism() {
		int i = (int) (Math.random() * criticismPool.length);
		return criticismPool[i];
	}

}
