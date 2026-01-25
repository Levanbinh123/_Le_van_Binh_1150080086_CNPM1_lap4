package javaapplication3;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

public class DemoTester {

    @BeforeClass
    public static void start() {
        System.out.println("Start");
    }

    @Before
    public void startTest() {
        System.out.println("Start Test case");
    }

    @Test
    public void test1() {
        System.out.println("Test case 1");
    }

    @Test
    public void test2() {
        System.out.println("Test case 2");
    }

    @After
    public void endTest() {
        System.out.println("End Test case");
    }

    @AfterClass
    public static void end() {
        System.out.println("End");
    }
}
