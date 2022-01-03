// Copy all values from dict except listed

const except = (incomingValues, ...exceptions) => {
  const KEYS = Object.keys(incomingValues);
  KEYS.forEach((key) => {
    if (exceptions.includes(key)) { 
      delete incomingValues[key];
    }
  });
  return incomingValues;
};

const result = except({ a: 1, b: 'two', c: 3, d: 4 }, 'a', 'd');
console.log(result);
