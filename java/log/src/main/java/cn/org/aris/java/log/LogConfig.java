package cn.org.aris.java.log;

public class LogConfig {
	private static final String LOG_BASE;
	private static String LOG_DIR;
	
	static {
		LOG_BASE = System.getProperty("user.home") + "/AppData/Local/Temp/aris.org.cn/";
	}
			
	public static void setLogPath(String path) {
		LOG_DIR = LOG_BASE + path;
		System.setProperty("LOGDIR", LOG_DIR);
	}
	
	public static String getLogPath() {
		return LOG_DIR;
	}
}
