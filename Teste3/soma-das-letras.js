// Dado que cada letra do alfabeto receba como valor a sua posição (a = 1, b = 2, c = 3, ... z =
// 26) escreva um programa que receba uma string e retorne o valor da soma de todas as
// letras:
// Exemplo:
// Input: “Abba”
// Output: “A Abba tem o valor de 6”
// a + b + b + a
// 1 + 2 + 2 + 1
// Usar como entrada os inputs abaixo:
// “Meu código não precisa de comentários”
// “Eu conserto depois”
// “É só uma pequena mudança”

let alfabeto = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'z'];
let string1 = 'Meu código não precisa de comentários';
let string2 = 'Eu conserto depois';
let string3 = 'É só uma pequena mudança';

function somaLetras(string) {
  string = string.toLowerCase();
  let soma = 0;
  for (let i = 0; i < string.length; i++) {
    for (let y = 0; y < alfabeto.length; y++) {
      if (string[i] == alfabeto[y]) {
        soma += y + 1;
      }
    }
  }
  return soma;
}

console.log(somaLetras(string1));
console.log(somaLetras(string2));
console.log(somaLetras(string3));

//OBRIGADO, OS TESTES FORAM DIVERTIDOS ;)