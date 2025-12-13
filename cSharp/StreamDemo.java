package scr;

import java.util.Scanner;

public class StreamDemo {
    public static void main(String[] args) {
        System.out.println("Stream");

        Scanner sc = new Scanner(System.in);

        System.out.print("Nhập tên: ");
        String name = sc.nextLine();

        System.out.println("Xin chào " + name);
    }
}
