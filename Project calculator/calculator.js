const OPERATIONS = {
  '+': (a, b) => a + b,
  '-': (a, b) => a - b,
  '*': (a, b) => a * b,
  '/': (a, b) => a / b
};

function calculate({a, b, operation}){
  
  const fun = OPERATIONS[operation];
  return fun(a, b); 

}


/*    Старый код
const OPERATIONS = {
  sum: "+",
  substruction: "-",     
  multiplication: "*",
  division: "/"
};
function calculate({a, b, operation}){
  let result = null;
  switch (operation) {
      case OPERATIONS.sum:
          result = sum(a, b);
          break;
      
      case OPERATIONS.substruction:
          result = substraction(a, b);
          break;
      
      case OPERATIONS.multiplication:
          result = multiplication(a, b);
          break;
      case OPERATIONS.division:
          result = divison(a, b);
          break;
      
      default:
          break;
  }
  
 
  return result;
}
*/
