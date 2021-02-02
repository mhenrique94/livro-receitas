let alcohol = 0;
let gasoline = 0;
let diesel = 0;
let code = 0;

while (code !== 4) {
  code = parseInt(gets());
    
    if(code === 1){
      alcohol++;
    }
    if(code === 2){
      gasoline++;
    }
    if(code === 3){
      diesel++;
    }else{
      continue;
    }
  
}

console.log("MUITO OBRIGADO");
console.log("Alcool: " + alcohol);
console.log("Gasolina: " + gasoline);
console.log("Diesel: " + diesel);
