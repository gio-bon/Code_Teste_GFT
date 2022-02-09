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

//pegará os índices das letras do alfabeto
let alfabeto = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'z'];
let string1 = 'Meu código não precisa de comentários';
let string2 = 'Eu conserto depois';
let string3 = 'É só uma pequena mudança';

function somaLetras(string) {
  string = string.toLowerCase(); //transforma tudo em letra minuscula
  let soma = 0; //guardará a soma dos índices + 1
  for (let i = 0; i < string.length; i++) { //percorre as strings
    for (let y = 0; y < alfabeto.length; y++) { //percorre alfabeto
      if (string[i] == alfabeto[y]) { //se houver correspondência ele  adicionará na variável soma
        soma += y + 1;
      }
    }
  }
  return soma; //retorno da soma
}

console.log(somaLetras(string1));
console.log(somaLetras(string2));
console.log(somaLetras(string3));

//OBRIGADO, OS TESTES FORAM DIVERTIDOS ;)