lançado em 1995 e criada por Brebdan Eich

moca > livescript > typescript > javascript

Javascript é uma tipagem fraca e dinâmica

### ES = ECMAScript
ECMAScript é uma especificação de linguagem script criada pela Ecma International, utilizada por linguagens como: ActionScript, JScript e Javascript.

### envio de proposta de implementação de açteração da linguagem

Stage 0: strawman, Stage 1: proposal, Stage 2: draft, Stage 3: candidate e Stage 4: finished


### função de primeira classe e ordem maior
É possível atribuir funções a variáveis, retornar funções de outras funções e passar funções como parâmetro para outras funções.

### tipagem fraca

não há verificação antes da compilação. Exemplo: dá para somar variável  int com string. resultado: uma concatenação.

### tipagem dinâmica
você não tem que definir o tipo da variável ao criá-la. Ao invés disso, o tipo da variável é definido automaticamente ao atribuir um valor à ela. Exemplo: (let numero = 10;)

### Boas práticas:

Typescript - um superset da js. adiciona tipo, interface, enum, etc, em tempo de execução.

### função de primeira classe

a função pode ser atribuida a variável, estrutura de dados (arrays, matriz, etc), chamada por argumentos


### Escopo global, de bloco ou função

----Inicio código

//escopo global

{
    //escopo de bloco
}

function test(){
    // escopo de função
}

fim do código----

### Hoisting

Hoisting ou içamento é a capacidade do JavaScript elevar a criação de variáveis e funções ao topo do escopo de suas criações. Existem dois tipos de Hoisting: hoisting de variável e hoisting de função.

### tipos de variáveis

var = utlizada antes do ES6

let, const = respeitam os escopos da estrutura do código

### tipos de variáveis

String
number
boolean
null
undefined
symbol
object
function
array


### funções

function fn(){
    return: "codigo aqui";
}

### #01 : Introdução ao ES6

https://www.youtube.com/watch?v=BZuIEd1ghmg

### #02 : Currying, tipos e variáveis

https://www.youtube.com/watch?v=IJIZNlrTo9o

### Tipos e variáveis
https://www.youtube.com/embed/aLBA_oYjqdw

### Functions e operadores

https://www.youtube.com/embed/K2VQgzer-mI

### Spread, estruturas condicionais e repetição

https://www.youtube.com/embed/W4MJu_O4CUc

### Estrutura básica de função 1
function Person(first, last, age, gender, interests) {
    this.name = {
      'first': first,
      'last' : last
    };
    this.age = age;
    this.gender = gender;
    this.interests = interests;
    this.bio = function() {
      alert(this.name.first + ' ' + this.name.last + ' is ' + this.age + ' years old. He likes ' + this.interests[0] + ' and ' + this.interests[1] + '.');
    };
    this.greeting = function() {
      alert('Hi! I\'m ' + this.name.first + '.');
    };
  }

  ### Estrutura básica de função 2
function SalaAula (alunos){
  this.alunos = alunos
}

SalaAula.prototype = {
  adicionarAluno: function(aluno){
    this.alunos.push(aluno)
}
}

const minhaSala = new SalaAula(["João", "Maria"]) <!-- cria um novo objeto chamado minhaSala herdando as propriedades da função SalaAula que adicionará o array com os dois nomes-->

minhaSala.adicionarAluno("Ricardo") <!-- chama a função adicionarALuno que foi herdada de SalaAula que adicionará um nome no array por meio do comando push>

  ### Conversões de input

  1) Number(n) // decide de acordo com o valor
  2) .parseint(n) // recebe inteiros
  3) .parsefloat(n) // recebe os flutuantes/reais
  4) String(n) // recebe n para string
  Fica:
        window.alert("A soma dos numeros é" + String(n))
    resultado:
        A soma dos numeros én

  5) n.tofixed(2).replace(".", ",")  <!-- // 2 é o n de casas depois da virgula e dentro do replace o caratere a ser substituido e ao caractere a substituir. -->
  6) n.toString // converte n (número) para string
    
  7) n.tolocalestring("pt-br", {style:'currency', currency: 'BRL'})


### node placeholder, formatação e escrita

Maneira masi fácil de alternar entre texto e variável

Antes
let soma;
console.log("A soma é "+ soma + "de reais")

Agora
console.log("A soma é ${soma} de reais")
            ou
document.writeln("A soma é <strong> ${soma.length} </strong> de reais")


### recebendo numero pelo pronpt e executando operação

var n1 = number(window.prompt("Digite um número inteiro"))
var n2 = number(window.prompt("Digite um número inteiro"))
var s = n1 + n2;
window.alert(" A soma é ${soma}!")

### Herança e prototype
https://www.youtube.com/watch?v=7ZxYJw9ebaM&ab_channel=SouDev

Javascript é tudo objeto praticamente. Objeto contém propriedades padrões que ficam dentro de um prototype (objeto.__proto__). É como uma cadeia, onde um objeto pode ter outro dentro dele e assim por diante, todos com seus prototypes, até que o final da cadeia seja nulo.




Criação de um objeto --> const meuObjeto = {a:1, b:2}

Estrutura da cadeia desse objeto

--> meuObjeto --> meuObjeto.__proto__ --> Object.prototype --> null


Ex.: Array

const meuArray = [1, 2, 3, [1, b]]

--> meuArray --> meuArray.__proto__ --> Array.prototype --> Object.prototype --> null
<!-- Um array tem em sua cadeia primeiramente as propriedades de um array (protótipo de array). Esse por sua vez tem as proriedades de um objeto já que esse protótipo por si só já é um objeto. Na cama superior e última, esse prototipo de objeo contem nulo-->

Funções tem as mesmas característica

Ex.:

function minhaFuncao(){
  return 1 +2
}

--> minhaFuncao --> minhaFuncao.__proto__ --> Function.prototype --> Object.prototype --> null

### quebrar vinculo da herança

Ao criar um objeto e herdar as propriedades e valores de outro de forma direta, cria-se um vínculo que pode levar ao erro na hora de manipular.

Ex.

const objeto = {a:1}

const novoobjeto = objeto //novoobjeto herdará a = 1 de objeto

ao tentar sobrescrever o valor para a =1 desse novoobjeto, a alteração ocorrerá também em objeto

novoobjeto.a = "mudei"

novoobjeto === {a: "mudei"} assim como objeto === {a: "mudei"}

 --> PARA QUEBRAR ESSE VINCULO, HERDAR SEMPRE COM COMANDO Object.create

 Ex.:

 const novoobjeto = Object.create(objeto)


### Object.create vs new Objeto()

O método Object.create recebe parâmetros. O primeiro é obrigatório e será usado como protótipo do novo objeto. O segundo é um mapa de propriedades com as quais objeto já "nasce".

Já new Object() é uma forma mais longa e não recomendada de se dizer {}.

As três linhas de código abaixo são equivalentes:

let a = {}; // legal
let b = new Object(); // coisa de dinossauros pedantes

let c = Object.create(null); // isso pode ser útil se ao invés de nulo
                             //você passar um parâmetro.
O método create pode ser bastante útil se você usar alguma lógica mais complexa para criar seus objetos. Novamente, os dois trechos de código abaixo são equivalentes:

// forma verbosa
let foo = {};
foo.prototype = Array;

let bar = {nome: "john", idade: 21};

for (let propriedade in bar) {
    foo[propriedade] = bar[propriedade];
}

// forma curta
let foo = Object.create(Array, {nome: "john", idade: 21});


