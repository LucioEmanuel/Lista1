//Criar uma calculadora que receba 2 numeros

import java.util.Scanner;

public class calc {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        //Colocado "s" como scanner

        System.out.println("Digite um número:");
        float num1 = s.nextFloat();
        System.out.println("Digite outro número:");
        float num2 = s.nextFloat();
        //Entrada de dados. Dois números, o numero 1 e o numero 2

        float soma = num1 + num2;
        float sub = num1 - num2;
        float mult = num1 * num2;
        float div = num1 / num2;
        //Soma, subtração, multiplicação e divisão dos dois números

        System.out.println("A soma dos números é: " + soma);
        System.out.println("A subtração dos números é: " + sub);
        System.out.println("A multiplicação dos números é: " + mult);
        System.out.println("A divisão dos números é: " + div);
        //Saida de dados. Mostra para o usuário o resultado das contas entre os dois números

        s.close();
        //Fechamento do Scanner
    }
}
