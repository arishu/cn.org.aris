package cn.org.aris.java.springmvc.webstore.interceptor;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.web.servlet.HandlerInterceptor;
import org.springframework.web.servlet.ModelAndView;

public class ProcessingTimeLogInterceptor implements HandlerInterceptor {

	private static final Logger logger = LoggerFactory.getLogger(ProcessingTimeLogInterceptor.class);
	
	/**
	 * This method will be called before Controller method is called
	 */
	@Override
	public boolean preHandle(HttpServletRequest request, HttpServletResponse response, Object handler)
			throws Exception {
		long startTime = System.currentTimeMillis();
		request.setAttribute("startTime", startTime);
		return true;
	}

	/**
	 * This method will be called after Controller method has been called
	 */
	@Override
	public void postHandle(HttpServletRequest request, HttpServletResponse response, Object handler,
			ModelAndView modelAndView) throws Exception {
		String queryString = request.getQueryString() == null ? "" : "?" + request.getQueryString();
		String path = request.getRequestURL() + queryString;
		
		long startTime = (long) request.getAttribute("startTime");
		long endTime = System.currentTimeMillis();
		logger.info(String.format("%s milliseconds taken to process the request %s", (endTime - startTime), path));
	}

	/**
	 * This method will be called when View has been rendered
	 */
	@Override
	public void afterCompletion(HttpServletRequest request, HttpServletResponse response, Object handler, Exception ex)
			throws Exception {
		logger.info("View has been rendered");
	}

}
