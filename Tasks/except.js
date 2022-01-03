// Copy all values from dict except listed

EXCEPT = (incomingvaluesarray, ...no) => {
  intermediate_variable = Object.keys(incomingvaluesarray);
  intermediate_variable.forEach((Z) => {
    if (no.includes(Z)) { 
      delete incomingvaluesarray[Z];
    }
  });
  return incomingvaluesarray;
};

const result = EXCEPT({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
