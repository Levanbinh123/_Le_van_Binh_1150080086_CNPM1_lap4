package javaapplication3;

import org.junit.runner.JUnitCore;
import org.junit.runner.Result;
import org.junit.runner.notification.Failure;

public class Test_runner {

    public static void main(String[] args) {

        System.out.println("===== RUNNING JUNIT TEST =====");

        Result result = JUnitCore.runClasses(DemoTester.class);

        if (result.wasSuccessful()) {
            System.out.println("SUCCESS - All test cases passed");
        } else {
            System.out.println("FAILED TEST CASES:");

            for (Failure failure : result.getFailures()) {
                System.err.println(failure.toString());
            }
        }

        System.out.println("===== END TEST =====");
    }
}