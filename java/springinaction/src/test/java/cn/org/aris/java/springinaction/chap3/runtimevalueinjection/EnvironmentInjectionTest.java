package cn.org.aris.java.springinaction.chap3.runtimevalueinjection;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.BeanCreationException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

public class EnvironmentInjectionTest {

	
	@RunWith(SpringJUnit4ClassRunner.class)
	@ContextConfiguration(classes=EnvironmentConfig.class)
	public static class InjectFromProperties {
		
		@Autowired
		private BlankDisc blankDisc;
		
		@Test
		public void assertBlankDiscProperties() {
			assertEquals("The Beatles", blankDisc.getArtist());
			assertEquals("Sgt. Peppers Lonely Hearts Club Band", blankDisc.getTitle());
		}
	}
	
	
	@RunWith(SpringJUnit4ClassRunner.class)
	@ContextConfiguration(classes=EnvironmentConfigWithDefaults.class)
	public static class InjectFromPropertiesWithDefaults {
		
		@Autowired
		private BlankDisc blankDisc;
		
		@Test
		public void assertBlankDiscProperties() {
			assertNotEquals("U2", blankDisc.getArtist());
			assertNotEquals("Rattle and Hum", blankDisc.getTitle());
		}
	}

	
	public static class InjectFromPropertiesWithRequiredProperties {
		
		@Test(expected=BeanCreationException.class)
		public void assertBlankDiscProperties() {
			new AnnotationConfigApplicationContext();
		}
	}
	
}
