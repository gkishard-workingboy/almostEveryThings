package servlet;

import java.io.*;
import java.util.Properties;

/**
 * FileHeader
 * Author by: GK
 * In 2019-十月-15
 * DOC:
 */
public class Test {
    public  static Properties pro = new Properties();
    public static void main(String[] args) {
        String username = "张顺涛";

        String path = Test.class.getClassLoader().getResource("loginList.properties").getPath();
        System.out.println(Test.class.getClassLoader().getResource("loginList.properties").getPath());
        System.out.println( new File(path).exists());
        System.out.println("C:\\Users\\GK\\Documents\\GitHub\\almostEveryThings\\FirstTaskOf_J2EE\\src\\servlet\\loginList.properties");
        try {
            pro.load(new FileReader("\\loginList.properties"));
        } catch (IOException e) {
            e.printStackTrace();
        }
        String returnKey = pro.getProperty(username);
        System.out.println(username+" : "+returnKey);try {
            pro.load(new FileReader(path));
        } catch (IOException e) {
            e.printStackTrace();
        }
        returnKey = pro.getProperty(username);
        System.out.println(username+" : "+returnKey);
    }
}
