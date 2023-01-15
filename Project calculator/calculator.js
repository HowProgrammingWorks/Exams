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

